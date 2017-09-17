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

namespace TwitchSharp.Winforms
{
    public partial class Form2 : Form
    {
        private SimpleInjector.Container container;
        private ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos> getTwitchTopVideosQueryHandler;
        private ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams> getTwitchLiveStreamsQueryHandler;
        private ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames> getTwitchTopGamesQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelSearchQuery, SearchChannels> getTwitchChannelSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelVideosSearchQuery, ChannelVideos> getTwitchChannelVideosSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchAuthTokenQuery, UsherTokenReply> getUsherTokenReplyQueryHandler;
        private ITwitchQueryHandler<GetTwitchVodInfoQuery, Vod> getTwitchVodInfoQueryHandler;
        private UsherTokenReply usherTokenReply;
        private ITwitchQueryHandler<GetTwitchM3UQuery, M3U> getM3U8QueryHandler;

        private ITwitchFileProcessor iTwitchFileProcessor;
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



            container = new SimpleInjector.Container();

            DIStartup d = new DIStartup();

            container = new Container();

            d.CreateContainer(container, twitchQueryOptionsJson, twitchHttpClientOptionsJson);

            
            container.Verify();

            

            this.getTwitchTopVideosQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos>>();
            this.getTwitchLiveStreamsQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams>>();
            this.getTwitchTopGamesQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames>>();
            
            this.getTwitchChannelSearchQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelSearchQuery, SearchChannels>>();
            this.getTwitchChannelVideosSearchQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchChannelVideosSearchQuery, ChannelVideos>>();
            this.getTwitchVodInfoQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchVodInfoQuery, Vod>>();
            this.getUsherTokenReplyQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchAuthTokenQuery, UsherTokenReply>>();

           

            this.iTwitchFileProcessor = container.GetInstance<ITwitchFileProcessor>();

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

            var querySearchChannel = container.GetInstance<GetTwitchChannelSearchQuery>();

            querySearchChannel.ChannelName = twitchChannelName;


            SearchChannels channelsearch = await getTwitchChannelSearchQueryHandler.HandleAsync(querySearchChannel);

            string text = JsonConvert.SerializeObject(channelsearch);

            textBoxLogs.Text = text;

           
        }

        private async void channelSearchByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int twitchChannelId = 28466675; //zlive


            var querySearchChannelVideos = container.GetInstance<GetTwitchChannelVideosSearchQuery>();

            querySearchChannelVideos.ChannelId = twitchChannelId;


            ChannelVideos channelvideos = await getTwitchChannelVideosSearchQueryHandler.HandleAsync(querySearchChannelVideos);

            string text = JsonConvert.SerializeObject(channelvideos);

            textBoxLogs.Text = text;

            

            //return twitchView;

        }

        private async void vodInfoByUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var queryVodInfo = container.GetInstance<GetTwitchVodInfoQuery>();

            //https://www.twitch.tv/videos/156832421
            queryVodInfo.VodUrl = "https://www.twitch.tv/videos/156832421";

            //queryVodInfo.VodId = 

            List<string> strings = queryVodInfo.VodUrl.Split('/').ToList<string>();
            if (strings == null || strings.Count == 0)
            {
                return;
            }

            queryVodInfo.VodId = strings[4];

            Vod vodinfo = await getTwitchVodInfoQueryHandler.HandleAsync(queryVodInfo);

            string text = JsonConvert.SerializeObject(vodinfo);

            textBoxLogs.Text = text;


           

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
            M3U m3u = new M3U();

            using (var reader = File.OpenText("m3u.txt"))
            {
                m3u.Text = await reader.ReadToEndAsync();

            }

            m3u.Text = m3u.Text.Replace("\"", "");

            m3u.Text = m3u.Text.Replace("\r", "");

            List<M3U8> m3u8list = iTwitchFileProcessor.GetM3U8List(m3u);

            string text = JsonConvert.SerializeObject(m3u8list);

            textBoxLogs.Text = text;

        }
        private async void getM38UByVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (usherTokenReply == null)
            {
                usherTokenReply = await GetUsherToken(156832421);

            }


            var queryM3U = container.GetInstance<GetTwitchM3UQuery>();

            int twitchVodId = 156832421; //zlive vod


            queryM3U.VodId = twitchVodId;
            queryM3U.NAuth = usherTokenReply.token;
            queryM3U.NAuthSig = usherTokenReply.sig;

            M3U m3U = await getM3U8QueryHandler.HandleAsync(queryM3U);

            string text = JsonConvert.SerializeObject(m3U);

            textBoxLogs.Text = text;


        }

        private async void getUsherTokenUsingVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            usherTokenReply = await GetUsherToken(156832421);

            string text = JsonConvert.SerializeObject(usherTokenReply);

            textBoxLogs.Text = text;

        }

        private async Task<UsherTokenReply> GetUsherToken(int twitchVodId)
        {
            var queryUsherTokenReply = container.GetInstance<GetTwitchAuthTokenQuery>();

            //int  = ; //zlive vod


            queryUsherTokenReply.VodId = twitchVodId;


            return await getUsherTokenReplyQueryHandler.HandleAsync(queryUsherTokenReply);



        }

    }
}
