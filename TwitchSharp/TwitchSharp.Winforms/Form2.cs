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

        int vodid;// = 176421657;
        M3U m3u;
        List<M3U8> m3u8list;
        Vod vodinfo;
        private bool loadingSettings;

        //string savedFolder;// = Properties.Settings.Default.SavedFolder;
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
            toolStripStatusLabelStatus.Text = "loading config";


            
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

            toolStripStatusLabelStatus.Text = "done loading config";

            UILoadSettings();

            
            


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

        

                        

        public async Task<Vod> GetVodInfoById()
        {
            var queryVodInfo = container.GetInstance<GetTwitchInfoVodQuery>();

            
            queryVodInfo.VodId = vodid.ToString();
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
           
            usherTokenReply = await GetUsherToken();

            m3u = await GetM3UByVodId();

            vodinfo = await GetVodInfoById();

            
            m3u8list = GetM3U8FromM3U();

            List<string> tsPieces;
        }

        private async void toolStripMenuM3UVodInfoById_Click(object sender, EventArgs e)
        {
           
            
            vodinfo = await GetVodInfoById();


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

        

        

        private void vodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        
        private async void buttonVodInfo_Click(object sender, EventArgs e)
        {
            buttonGetVodInfo.Enabled = false;



            vodinfo = await GetVodInfoById();

            
            UIShowVodDetails();

            await UIGetThumbnail();

            await ProcessQualities(vodid);

            UIDownloadCheck();

           
            string text = JsonConvert.SerializeObject(vodinfo);

            textBoxLogs.Text = text;

            buttonGetVodInfo.Enabled = true;

        }

        private async Task UIGetThumbnail()
        {
            GetTwitchImageQuery imageQuery = container.GetInstance<GetTwitchImageQuery>();

            imageQuery.ImageUrl = vodinfo.thumbnails.medium.FirstOrDefault().url;

            Image image = await this.getTwitchImageQueryHandler.HandleAsync(imageQuery);

            pictureBox1.Image = image;
        }
        private void UIShowVodDetails()
        {
            textBoxVodTitle.Text = vodinfo.title;
            textBoxVodGame.Text = vodinfo.game;
            textBoxVodDate.Text = vodinfo.created_at;
            textBoxVodLength.Text = vodinfo.length.ToString();
            textBoxVodViews.Text = vodinfo.views.ToString();
        }

        private async Task ProcessQualities(int vodid)
        {

            GetTwitchVodQualitiesById queryVodQualities = container.GetInstance<GetTwitchVodQualitiesById>();

            queryVodQualities.VodId = vodid.ToString();

            List<TwitchVideoQuality> qualityList = await this.getTwitchGetTwitchVodQualitiesByIdHandler.HandleAsync(queryVodQualities);

            string textVodQuality = JsonConvert.SerializeObject(qualityList);

            textBoxLogs.Text += textVodQuality;

            if (qualityList != null && qualityList.Count > 0)
            {
                QualityEnable();
                QualityBindAndPopulate(qualityList);
            }
            else
            {
                QualityUnbind();
                QualityDisable();

            }





        }

        private void QualityBindAndPopulate(List<TwitchVideoQuality> qualityList)
        {
            comboBoxQuality.BindingContext = this.BindingContext;

            this.comboBoxQuality.DisplayMember = "DisplayString";
            this.comboBoxQuality.ValueMember = "QualityId";
            comboBoxQuality.DataSource = qualityList;
        }

        private void QualityUnbind()

        {
            comboBoxQuality.DataSource = null;
            comboBoxQuality.BindingContext = null;

        }
        private void QualityDisable()
        {
            comboBoxQuality.Enabled = false;
            
        }
        private void QualityEnable()
        {
            comboBoxQuality.Enabled = false;
            
        }

        private void UIVodIdCheck()
        {

            string tmp;
            tmp = textBoxTwitchUrl.Text.Replace("https://www.twitch.tv/videos/", "");
            bool shouldBeEnabled = false;
                          

            if (!Int32.TryParse(tmp, out this.vodid))
            {
                //MessageBox.Show("can't get vod id from url.");
                shouldBeEnabled = false;

            }
            else
            {
                shouldBeEnabled = true;

                UISaveSettings();

            }

            buttonGetVodInfo.Enabled = shouldBeEnabled;
            
            

        }

        private void UILoadSettings()
        {
            loadingSettings = true;
            string twitchUrl = Properties.Settings.Default.TwitchUrl;
            if (twitchUrl != null && twitchUrl != "")
            {
                textBoxTwitchUrl.Text = twitchUrl;
            }


            if (Directory.Exists(Properties.Settings.Default.SavedFolder))
            {
                textBoxFolder.Text = Properties.Settings.Default.SavedFolder;
                folderBrowserDialog1.SelectedPath = textBoxFolder.Text;
            }

            loadingSettings = false;



        }
        private void UISaveSettings()
        {
            Properties.Settings.Default.TwitchUrl = textBoxTwitchUrl.Text;

            Properties.Settings.Default.Save();

        }

        
        private void UISaveSettingsFolder()
        {

            if (!Directory.Exists(textBoxFolder.Text)) return;
            Properties.Settings.Default.SavedFolder = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.Save();
        }
        private void UIDownloadCheck()
        {
            bool shouldBeEnabled = comboBoxQuality.Items.Count > 0;
            buttonDownload.Enabled = shouldBeEnabled;
            buttonAddToQueue.Enabled = shouldBeEnabled;
            comboBoxQuality.Enabled = shouldBeEnabled;

        }

        private void textBoxTwitchUrl_TextChanged(object sender, EventArgs e)
        {

            UIVodIdCheck();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonChangeFolder_Click(object sender, EventArgs e)
        {


            string savedFolder = textBoxFolder.Text;
            if (Directory.Exists(savedFolder))
            {
                folderBrowserDialog1.SelectedPath = savedFolder;
            }
            else
            {
                folderBrowserDialog1.SelectedPath = "";
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
                

            }
        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            if (loadingSettings) return;
            UISaveSettingsFolder();
        }
    }
}
