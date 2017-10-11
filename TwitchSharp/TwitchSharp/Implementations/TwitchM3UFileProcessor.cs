using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchM3UFileProcessor : ITwitchM3UFileProcessor
    {

        List<string> linelist;
        string text;

        public List<M3U8> M3U8s;

        public List<M3U8> GetM3U8List(M3U m3u)
        {

            this.text = m3u.Text;
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
                                AddM3U8Properties(m, linelist[line +1]);
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

            for (int count = 0; count< t.Count; count++)

            {
                string[] item = t[count].Split('=');

                PropertyInfo p = m.GetType().GetProperty(item[0], BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (p != null)
                {
                    //m.GetType.GetProperties().FirstOrDefault(x => x.Name == item[0]).SetValue(m, item[0]);

                    p.SetValue(m, item[1]);
                    
                }


            }

        }

    }
}
