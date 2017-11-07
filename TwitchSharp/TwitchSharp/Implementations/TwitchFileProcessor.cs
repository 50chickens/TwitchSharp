using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;
using Twitch.Api;
using System.Reflection;

namespace TwitchSharp.Implementations
{
    public class TwitchFileProcessor : ITwitchFileProcessor
    {

        public List<TwitchDownload> GetDownloadsFromPlaylist(List<string> playlist, string baseurl, string folder, string incquality, string quality)
        {

            
            List<TwitchDownload> downloads = new List<TwitchDownload>();

            baseurl = baseurl.Replace(incquality + @"/index-dvr.m3u8", quality + @"/" );

            for (int x = 0; x < playlist.Count; x++)
            {
                TwitchDownload d = new TwitchDownload()
                { 
                    
                    Folder = folder,
                    DownloadParameters = new TwitchDownloadParameters()
                    {
                        Url = baseurl + playlist[x],
                        Filename = @"\" + playlist[x]
                    }
                    
                };

                downloads.Add(d);

            }

            return downloads;
        }


        public List<string> GetPlaylistFiles(string m3utext)
        {
            List<string> linelist;
            List<string> playlistfiles;


            
            if (!m3utext.Contains("\n") || (m3utext.Split('\n').ToList().Count < 1))
            {
                return null;
                
            }
            linelist = m3utext.Split('\n').ToList();

            if (!linelist[0].Contains(@"#EXTM3U"))
            {
                return null;
            }
            


            playlistfiles = linelist.Where(x => (!x.Contains(@"#") && x.Contains(@".ts"))).ToList();

            playlistfiles.Sort();


            return playlistfiles;




        }

        public M3U8 GetM3U8(string text)
        {
            M3U8 m3u8 = new M3U8(text);

            return m3u8;

        }

        public List<M3U8> GetM3U8List(string text)
        {
           
            List<string> linelist;
            
            List<M3U8> m3u8list;

            if (text == "")
            {
                return null;
            }

            linelist = text.Split('\n').ToList();

            if (linelist.Count > 0)
            {
                m3u8list = new List<M3U8>();

            }
            else
            {
                return null;
            }
            for (int line = 0; line <= linelist.Count - 2; line += 1)
            {
                if (linelist[line].Contains("#EXT-X-MEDIA"))
                {

                    if (linelist[line + 1].Contains("#EXT-X-STREAM-INF"))
                    {

                        if (linelist[line + 2].Contains("http") && linelist[line + 2].Contains("m3u8"))
                        {
                            M3U8 m = new M3U8(linelist[line], linelist[line + 1], linelist[line + 2]);

                            if (m != null)
                            {
                                AddM3U8Properties(m, linelist[line]);
                                AddM3U8Properties(m, linelist[line + 1]);
                                m3u8list.Add(m);
                            }


                        }
                    }

                }
            }
            return m3u8list;
        }


        private void AddM3U8Properties(M3U8 m, string line)
        {
            if (!line.Contains(","))
            {
                return;
            }
            List<string> t = line.Split(',').ToList();

            if (t.Count == 0)
            {
                return;
            }

            for (int count = 0; count < t.Count; count++)

            {
                string[] item = t[count].Split('=');

                int fps = 0;

                if (item[0] == "GROUP-ID" && int.TryParse(item[1].Split('p')[1], out fps))
                {
                    m.Fps = fps;
                }
                PropertyInfo p = m.GetType().GetProperty(item[0], BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (p != null)
                {


                    p.SetValue(m, item[1]);

                }


            }

        }



        public List<TwitchVideoQuality> GetVodQualities(string vodInfoResponse)
        {
            JObject videosResponseJson = JObject.Parse(vodInfoResponse);

            List<TwitchVideoQuality> qualities = ParseQualities(videosResponseJson.Value<JObject>("resolutions"), videosResponseJson.Value<JObject>("fps"));

            return qualities;
        }

        public List<TwitchVideoQuality> ParseQualities(JObject resolutionsJson, JObject fpsJson)
        {
            List<TwitchVideoQuality> qualities = new List<TwitchVideoQuality>();

            Dictionary<string, string> fpsList = new Dictionary<string, string>();

            if (fpsJson != null)
            {
                foreach (JProperty fps in fpsJson.Values<JProperty>())
                {
                    fpsList.Add(fps.Name, ((int)Math.Round(fps.Value.Value<double>(), 0)).ToString());
                }
            }

            if (resolutionsJson != null)
            {
                foreach (JProperty resolution in resolutionsJson.Values<JProperty>())
                {
                    string value = resolution.Value.Value<string>();
                    string qualityId = resolution.Name;
                    string fps = fpsList.ContainsKey(qualityId) ? fpsList[qualityId] : null;

                    qualities.Add(new TwitchVideoQuality(qualityId, value, fps));
                }
            }

            if (fpsList.ContainsKey(TwitchVideoQuality.QUALITY_AUDIO))
            {
                qualities.Add(new TwitchVideoQuality(TwitchVideoQuality.QUALITY_AUDIO));
            }

            if (!qualities.Any())
            {
                qualities.Add(new TwitchVideoQuality(TwitchVideoQuality.QUALITY_SOURCE));
            }

            qualities.Sort();

            return qualities;
        }

        
    }
}
