using SimpleInjector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitch.Api.LiveStreams;
using Twitch.Api.TopGames;
using Twitch.Api.TopVideos;
using TwitchSharp.Abstractions;
using TwitchSharp.Implementations;
using Twitch.Api.SearchChannel;
using Twitch.Api.ChannelVideos;
using Twitch.Api.Vod;
using Twitch.Api.Usher;
using System.IO;
using TwitchSharp.Di;
using Twitch.Api;
using Twitch.Api.Channel;
using System.Reflection;
using TwitchSharp.Api;

namespace TwitchSharp.Winforms
{
    public partial class Form2 : Form
    {
        private SimpleInjector.Container container;
        private ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos> getTwitchTopVideosQueryHandler;
        private ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams> getTwitchLiveStreamsQueryHandler;
        private ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames> getTwitchTopGamesQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelSearchByNameQuery, SearchChannels> getTwitchChannelSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos> getTwitchChannelVideosSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelInfoQuery, ChannelInfo> getTwitchChannelInfoSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchAuthTokenQuery, UsherTokenReply> getUsherTokenReplyQueryHandler;
        private ITwitchQueryHandler<GetTwitchInfoVodQuery, Vod> getTwitchVodInfoByIdQueryHandler;
        private UsherTokenReply usherTokenReply;
        private ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos> getTwitchChannelVideosByIdQueryHandler;
        private ITwitchQueryHandler<GetTwitchM3UQuery, M3U> getM3U8QueryHandler;
        private ITwitchQueryHandler<GetTwitchImageQuery, Image> getTwitchImageQueryHandler;

        private ITwitchQueryHandler<GetTwitchVodQualitiesById, List<TwitchVideoQuality>> getTwitchGetTwitchVodQualitiesByIdHandler;
        private ITwitchM3UFileProcessor iTwitchM3UFileProcessor;

        int vodid = 176421657;
        M3U m3u;
        List<M3U8> m3u8list;
        Vod vodinfo;

        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }


        private async void Form2_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "loading config";


            menuStrip1.Enabled = false;

            string twitchQueryOptionsJson;
            using (var reader = File.OpenText("TwitchQueryOptions.json"))
            {
                twitchQueryOptionsJson = await reader.ReadToEndAsync();

            }

            string twitchHttpClientOptionsJson;
            using (var reader = File.OpenText("TwitchHttpClientOptions.json"))
            {
                twitchHttpClientOptionsJson = await reader.ReadToEndAsync();

            }



            string twitchVodInfoJson;
            using (var reader = File.OpenText("vodinfobyid.txt"))
            {
                twitchVodInfoJson = await reader.ReadToEndAsync();

            }

            container = new SimpleInjector.Container();

            DIStartup d = new DIStartup();

            container = new Container();

            d.CreateContainer(container, twitchQueryOptionsJson, twitchHttpClientOptionsJson);


            container.Verify();



            this.getTwitchTopVideosQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos>>();
            this.getTwitchLiveStreamsQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams>>();
            this.getTwitchTopGamesQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames>>();

            this.getTwitchChannelSearchQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelSearchByNameQuery, SearchChannels>>();
            this.getTwitchChannelInfoSearchQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelInfoQuery, ChannelInfo>>();

            this.getTwitchChannelVideosSearchQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos>>();
            this.getTwitchGetTwitchVodQualitiesByIdHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchVodQualitiesById, List<TwitchVideoQuality>>>();
            this.getUsherTokenReplyQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchAuthTokenQuery, UsherTokenReply>>();

            this.getTwitchVodInfoByIdQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchInfoVodQuery, Vod>>();
            this.getTwitchImageQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchImageQuery, Image>>();

            this.getTwitchChannelVideosByIdQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos>>();
            this.getM3U8QueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3UQuery, M3U>>();



            this.iTwitchM3UFileProcessor = container.GetInstance<ITwitchM3UFileProcessor>();

            toolStripStatusLabel1.Text = "done loading config";


            menuStrip1.Enabled = true;

        }


        private async void topVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {



            var queryTopVideos = container.GetInstance<GetTwitchTopVideosQuery>();

            queryTopVideos.Limit = 18;


            TwitchTopVideos topvideos = await getTwitchTopVideosQueryHandler.HandleAsync(queryTopVideos);



            string text = JsonConvert.SerializeObject(topvideos);

            textBoxLogs.Text = text;


        }

        private async void topLiveStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var queryLiveStreams = container.GetInstance<GetTwitchLiveStreamsQuery>();

            queryLiveStreams.Limit = 18;


            LiveStreams livestreams = await getTwitchLiveStreamsQueryHandler.HandleAsync(queryLiveStreams);

            string text = JsonConvert.SerializeObject(livestreams);

            textBoxLogs.Text = text;

            //return twitchView;


            //TwitchClient tc = BusinessManager.CreateTwitchClient();

            ////try
            ////{
            ////    string topStreams = await tc.GetTopLiveStreamsAsString();
            ////    textBoxWebApi.Text = topStreams;
            ////}
            ////catch (Exception ex)
            ////{
            ////    textBoxWebApi.Text = ex.Message;
            ////}
        }





        private async void topGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var queryTopGames = container.GetInstance<GetTwitchTopGamesQuery>();

            queryTopGames.Limit = 18;

            TopGames topgames = await getTwitchTopGamesQueryHandler.HandleAsync(queryTopGames);

            string text = JsonConvert.SerializeObject(topgames);

            textBoxLogs.Text = text;

        }





        private async void channelSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string twitchChannelName = "zlive";

            var querySearchChannel = container.GetInstance<GetTwitchChannelSearchByNameQuery>();

            querySearchChannel.ChannelName = twitchChannelName;


            SearchChannels channelsearch = await getTwitchChannelSearchQueryHandler.HandleAsync(querySearchChannel);

            string text = JsonConvert.SerializeObject(channelsearch);

            textBoxLogs.Text = text;


        }

        private async void channelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string twitchChannelId = "28466675"; //zlive


            var queryChannelInfo = container.GetInstance<GetTwitchChannelInfoQuery>();

            queryChannelInfo.ChannelId = twitchChannelId;


            ChannelInfo channelvideos = await getTwitchChannelInfoSearchQueryHandler.HandleAsync(queryChannelInfo);

            string text = JsonConvert.SerializeObject(channelvideos);

            textBoxLogs.Text = text;



            //return twitchView;

        }

        private async void vodInfoByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            




        }

        private async void liveStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var queryLiveStreams = container.GetInstance<GetTwitchLiveStreamsQuery>();

            queryLiveStreams.Limit = 18;

            LiveStreams livestreams = await getTwitchLiveStreamsQueryHandler.HandleAsync(queryLiveStreams);

            string text = JsonConvert.SerializeObject(livestreams);

            textBoxLogs.Text = text;

        }

        private async void loadM3U8ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            usherTokenReply = await GetUsherToken();

            m3u = await GetM3UByVodId();


            m3u8list = GetM3U8FromM3U();

            string text = JsonConvert.SerializeObject(m3u8list);

            textBoxLogs.Text = text;

        }
        private async void getM38ByVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {



            usherTokenReply = await GetUsherToken();

            m3u = await GetM3UByVodId();

            string text = JsonConvert.SerializeObject(m3u);

            textBoxLogs.Text = text;


        }

        private async void getUsherTokenUsingVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            usherTokenReply = await GetUsherToken();

            string text = JsonConvert.SerializeObject(usherTokenReply);

            textBoxLogs.Text = text;

        }

        

                        

        public async Task<Vod> GetVodInfoById(int vodid)
        {
            var queryVodInfo = container.GetInstance<GetTwitchInfoVodQuery>();

            string VodUrl = "https://www.twitch.tv/videos/" + vodid.ToString();

            queryVodInfo.PropertyMapping = new Dictionary<string, string>
            {
                {"chunked", "chunked"},
                {"mobile", "160p30"},
                {"low", "360p30"},
                {"medium", "480p30"},
                {"high", "720p30"}
             };

            queryVodInfo.VodUrl = VodUrl;
            vodinfo = await getTwitchVodInfoByIdQueryHandler.HandleAsync(queryVodInfo);
            return vodinfo;
        }
        private List<M3U8> GetM3U8FromM3U()
        {
            return m3u8list = iTwitchM3UFileProcessor.GetM3U8List(m3u);
        }
        private async Task<M3U> GetM3UByVodId()
        {
            var queryM3U = container.GetInstance<GetTwitchM3UQuery>();


            queryM3U.VodId = vodid;
            queryM3U.NAuth = usherTokenReply.token;
            queryM3U.NAuthSig = usherTokenReply.sig;

            return await getM3U8QueryHandler.HandleAsync(queryM3U);
        }
        private async Task<UsherTokenReply> GetUsherToken()
        {
            var queryUsherTokenReply = container.GetInstance<GetTwitchAuthTokenQuery>();

            queryUsherTokenReply.VodId = vodid;

            return await getUsherTokenReplyQueryHandler.HandleAsync(queryUsherTokenReply);



        }

        private async void channelVideosByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string twitchChannelId = "28466675"; //zlive


            var queryChannelVideosById = container.GetInstance<GetTwitchChannelVideosByIdQuery>();

            queryChannelVideosById.ChannelId = twitchChannelId;


            ChannelVideos channelvideos = await getTwitchChannelVideosByIdQueryHandler.HandleAsync(queryChannelVideosById);

            string text = JsonConvert.SerializeObject(channelvideos);

            textBoxLogs.Text = text;

        }

        private async void getTSPiecesFromM3U8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int vodid = this.vodid;
            usherTokenReply = await GetUsherToken();

            m3u = await GetM3UByVodId();

            vodinfo = await GetVodInfoById(vodid);

            
            m3u8list = GetM3U8FromM3U();

            List<string> tsPieces;
        }

        private async void toolStripMenuM3UVodInfoById_Click(object sender, EventArgs e)
        {
           
            int vodid = this.vodid;
            vodinfo = await GetVodInfoById(vodid);


            foreach (PropertyInfo p in vodinfo.fps.GetType().GetProperties())
            {
                PropertyInfo p2 = vodinfo.resolutions.GetType().GetProperty(p.Name);
                if (p2 != null)

                {
                   object resolution =  p2.GetValue(vodinfo.resolutions);
                    ToolStripMenuItem t = new ToolStripMenuItem();

                    t.Text = resolution.ToString();

                    toolStripMenuM3UVodInfoById.DropDownItems.Add(t);

                }

           


            }
                       

        }

        private async void parseQualitiesFromVodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int vodid = this.vodid;
            //vodinfo = await GetVodInfoById(vodid);

            GetTwitchVodQualitiesById query = container.GetInstance<GetTwitchVodQualitiesById>();

            query.VodId = vodid.ToString();

            List<TwitchVideoQuality> qualityList = await this.getTwitchGetTwitchVodQualitiesByIdHandler.HandleAsync(query);

            string text = JsonConvert.SerializeObject(qualityList);

            textBoxLogs.Text = text;

            if (qualityList != null && qualityList.Count > 0)
            {
                PopulateQualityComboBox(qualityList);
            }
            else
            {
                comboBoxQuality.Enabled = false;
                comboBoxQuality.DataSource = null;
                comboBoxQuality.BindingContext = null;
            }


        }

        private void PopulateQualityComboBox(List<TwitchVideoQuality> qualityList)
        {
            comboBoxQuality.BindingContext = this.BindingContext;

            this.comboBoxQuality.DisplayMember = "DisplayString";
            this.comboBoxQuality.ValueMember = "QualityId";
            comboBoxQuality.DataSource = qualityList;
        }

        private void vodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private async void buttonVodInfo_Click(object sender, EventArgs e)
        {
            string tmp;
            int vodid;
            if (textBoxTwitchUrl.Text.Contains("https://www.twitch.tv/videos/"))

            {
                tmp = textBoxTwitchUrl.Text.Replace("https://www.twitch.tv/videos/", "");
            }
            else
            {
                tmp = textBoxTwitchUrl.Text;
            }
            
            if (!Int32.TryParse(tmp, out vodid))
            {
                MessageBox.Show("can't get vod id from url.");
                return;
            }

            vodinfo = await GetVodInfoById(vodid);

            textBoxVodTitle.Text = vodinfo.title;
            textBoxVodGame.Text = vodinfo.game;
            textBoxVodDate.Text = vodinfo.created_at;
            textBoxVodLength.Text = vodinfo.length.ToString();
            textBoxVodViews.Text = vodinfo.views.ToString()    ;

            //if (vodinfo.thumbnails.small != "")
            //{
            //   // pictureBox1.Image
            //}

            GetTwitchImageQuery query = container.GetInstance<GetTwitchImageQuery>();

            query.ImageUrl = vodinfo.thumbnails.medium.FirstOrDefault().url;

            Image image = await this.getTwitchImageQueryHandler.HandleAsync(query);


            pictureBox1.Image = image;

            //foreach (PropertyInfo p in vodinfo.GetType().GetProperties())
            //{

            //    if (p.PropertyType == typeof(string))
            //    {
            //        PropertyInfo p2 = vodinfo.GetType().GetProperty(p.Name);
            //        object strValue = p2.GetValue(vodinfo);

            //        textBoxVodInfo.Text += p.Name + ":" + strValue.ToString() + "\r\n";
            //    }






            //}

            string text = JsonConvert.SerializeObject(vodinfo);

            textBoxLogs.Text = text;
        }

        private void textBoxTwitchUrl_TextChanged(object sender, EventArgs e)
        {
            buttonGetVodInfo.Enabled = (textBoxTwitchUrl.Text.Length > 0);

            
        }
    }
}
