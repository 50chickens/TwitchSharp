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
using TwitchSharp.Service;
using System.Threading;

namespace TwitchSharp.Winforms
{
    public partial class Form2 : Form
    {
        CancellationTokenSource cts;
        private SimpleInjector.Container container;
        private ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos> getTwitchTopVideosQueryHandler;
        private ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams> getTwitchLiveStreamsQueryHandler;
        private ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames> getTwitchTopGamesQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelSearchByNameQuery, SearchChannels> getTwitchChannelSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos> getTwitchChannelVideosSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchChannelInfoQuery, ChannelInfo> getTwitchChannelInfoSearchQueryHandler;
        private ITwitchQueryHandler<GetTwitchAuthTokenQuery, UsherTokenReply> getUsherTokenReplyQueryHandler;
        private ITwitchQueryHandler<GetTwitchInfoVodQuery, Vod> getTwitchVodInfoByIdQueryHandler;
        private UsherTokenReply UsherTokenReply;
        private ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos> getTwitchChannelVideosByIdQueryHandler;


        private ITwitchQueryHandler<GetTwitchM3UTextQuery, string> getM3UTextQueryHandler;
        private ITwitchQueryHandler<GetTwitchM3UQuery, M3U> getM3UQueryHandler;

        private ITwitchQueryHandler<GetTwitchM3U8TextQuery, string> getM3U8TextQueryHandler;
        private ITwitchQueryHandler<GetTwitchM3U8Query, M3U8> getM3U8QueryHandler;



        private ITwitchQueryHandler<GetTwitchImageQuery, Image> getTwitchImageQueryHandler;
        private ITwitchQueryHandler<GetTwitchDownloadQuery, List<TwitchDownload>> getTwitchDownloadQueryHandler;

        private ITwitchQueryHandler<GetTwitchM3U8ListQuery, List<M3U8>> getM3U8ListQueryHandler;

        private ICommandHandler<DownloadFileCommand> downloadFileCommandHandler;

        private ITwitchQueryHandler<GetTwitchVodQualitiesById, List<TwitchVideoQuality>> getTwitchGetTwitchVodQualitiesByIdHandler;


        int vodid;// = 176421657;
        M3U8 M3u8;
        List<M3U8> M3u8list;

        Vod Vodinfo;
        private bool loadingSettings;
        List<VodSearchParameters> vodSearchParameters;


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

            this.getM3UTextQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3UTextQuery, string>>();
            this.getM3UQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3UQuery, M3U>>();

            this.getM3U8TextQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3U8TextQuery, string>>();
            this.getM3U8QueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3U8Query, M3U8>>();

            this.getM3U8ListQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchM3U8ListQuery, List<M3U8>>>();



            this.getTwitchDownloadQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchDownloadQuery, List<TwitchDownload>>>();
            this.downloadFileCommandHandler = container.GetInstance<ICommandHandler<DownloadFileCommand>>();

            //this.iTwitchM3UFileProcessor = container.GetInstance<ITwitchM3UFileProcessor>();

            //this.getTwitchTSPlaylistQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTSPlaylistQuery, List<string>>>();



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


            UsherTokenReply = await GetUsherToken();

            string m3u8text = await GetM3U8TextByVodId();

            M3u8list = await GetM3U8ListFromM3U8Text(m3u8text);

            string text = JsonConvert.SerializeObject(M3u8list);

            textBoxLogs.Text = text;

        }
        private async void getM38ByVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {



            UsherTokenReply = await GetUsherToken();

            string m3u8text = await GetM3U8TextByVodId();


            string text = JsonConvert.SerializeObject(m3u8text);

            textBoxLogs.Text = text;


        }

        private async void getUsherTokenUsingVodIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UsherTokenReply = await GetUsherToken();

            string text = JsonConvert.SerializeObject(UsherTokenReply);

            textBoxLogs.Text = text;

        }





        public async Task<Vod> GetVodInfoById()
        {
            var queryVodInfo = container.GetInstance<GetTwitchInfoVodQuery>();


            queryVodInfo.VodId = vodid.ToString();

            try
            {
                Vodinfo = await getTwitchVodInfoByIdQueryHandler.HandleAsync(queryVodInfo);
                return Vodinfo;
            }
            catch (Exception ex)
            {
                return null;
            }
                
        }

        private async Task<List<M3U8>> GetM3U8ListFromM3U8Text(string m3u8text)
        {
            var getM3U8ListQuery = container.GetInstance<GetTwitchM3U8ListQuery>();
            getM3U8ListQuery.Text = m3u8text;

            return await getM3U8ListQueryHandler.HandleAsync(getM3U8ListQuery);

        }
        private async Task<string> GetM3U8TextByVodId()
        {
            var queryM3U8Text = container.GetInstance<GetTwitchM3U8TextQuery>();


            queryM3U8Text.VodId = vodid;
            queryM3U8Text.NAuth = UsherTokenReply.token;
            queryM3U8Text.NAuthSig = UsherTokenReply.sig;


            string text = await getM3U8TextQueryHandler.HandleAsync(queryM3U8Text);

            return text;

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

            Vodinfo = await GetVodInfoById();

            UsherTokenReply = await GetUsherToken();

            string m3u8text = await GetM3U8TextByVodId();

            M3u8list = await GetM3U8ListFromM3U8Text(m3u8text);

            List<string> tsPieces;
        }

        private async void toolStripMenuM3UVodInfoById_Click(object sender, EventArgs e)
        {


            Vodinfo = await GetVodInfoById();


            foreach (PropertyInfo p in Vodinfo.fps.GetType().GetProperties())
            {
                PropertyInfo p2 = Vodinfo.resolutions.GetType().GetProperty(p.Name);
                if (p2 != null)

                {
                    object resolution = p2.GetValue(Vodinfo.resolutions);
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

            Vodinfo = await GetVodInfoById();

            if (Vodinfo == null)
            {
                MessageBox.Show("Can't load vod");
                return;
            }
            UIShowVodDetails();

            await UIGetThumbnail();

            await ProcessQualities(vodid);

            UIDownloadCheck();

            string text = JsonConvert.SerializeObject(Vodinfo);

            textBoxLogs.Text = text;

            buttonGetVodInfo.Enabled = true;

        }

        private async Task UIGetThumbnail()
        {
            GetTwitchImageQuery imageQuery = container.GetInstance<GetTwitchImageQuery>();

            imageQuery.ImageUrl = Vodinfo.thumbnails.medium.FirstOrDefault().url;

            Image image = await this.getTwitchImageQueryHandler.HandleAsync(imageQuery);

            pictureBox1.Image = image;
        }
        private void UIShowVodDetails()
        {
            textBoxVodTitle.Text = Vodinfo.title;
            textBoxVodGame.Text = Vodinfo.game;
            textBoxVodDate.Text = Vodinfo.created_at;
            textBoxVodLength.Text = Vodinfo.length.ToString();
            textBoxVodViews.Text = Vodinfo.views.ToString();
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
            //comboBoxQuality.BindingContext = this.BindingContext;

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


            UISearchParametersLoad();
            UISearchParametersBind();
            UISearchParametersEnable();



        }

        private void UISearchParametersEnable()
        {
            comboBoxSearchType.Enabled = true;
        }

        public void UISearchParametersLoad()

        {

            vodSearchParameters = new List<VodSearchParameters>();

            vodSearchParameters.Add(new VodSearchParameters("Channel", SearchParameter.Channel));
            vodSearchParameters.Add(new VodSearchParameters("Game", SearchParameter.Game));


            // VodSearchParameters 
            //comboBoxSearchType.DataBindings = 
        }

        private void UISearchResultsBind(object o)
        {

            //this.comboBoxSearchType.DisplayMember = displayMember;
            //this.comboBoxSearchType.ValueMember = parameter;
            BindingSource b = new BindingSource();
            b.DataSource = o;
            dataGridView1.DataSource = b;

        }
        private void UISearchParametersBind()
        {

            this.comboBoxSearchType.DisplayMember = "DisplayText";
            this.comboBoxSearchType.ValueMember = "Parameter";
            comboBoxSearchType.DataSource = vodSearchParameters;
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

        private async void buttonGetChart_Click(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;

            string twitchChannelName = textBoxTwitchSearch.Text;

            var querySearchChannel = container.GetInstance<GetTwitchChannelSearchByNameQuery>();

            querySearchChannel.ChannelName = twitchChannelName;


            SearchChannels channelsearch = await getTwitchChannelSearchQueryHandler.HandleAsync(querySearchChannel);

            string text = JsonConvert.SerializeObject(channelsearch);

            textBoxLogs.Text = text;

            if (channelsearch._total > 0)
            {
                Twitch.Api.SearchChannel.Channel channel = channelsearch.channels.Where(x => x.name == twitchChannelName).FirstOrDefault();

                if (channel != null)
                {
                    string twitchChannelId = channel._id.ToString(); //zlive

                    var queryChannelVideosById = container.GetInstance<GetTwitchChannelVideosByIdQuery>();

                    queryChannelVideosById.ChannelId = twitchChannelId;

                    ChannelVideos channelvideos = await getTwitchChannelVideosByIdQueryHandler.HandleAsync(queryChannelVideosById);

                    string channelvideosText = JsonConvert.SerializeObject(channelvideos);

                    UISearchResultsBind(channelvideos.videos);
                    textBoxLogs.Text += channelvideosText;
                }

            }

            buttonSearch.Enabled = true;
        }

        private void textBoxTwitchSearchChannelName_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = (textBoxTwitchUrl.Text.Length > 0);

        }

        private async void buttonAddToQueue_Click(object sender, EventArgs e)
        {
            if (Vodinfo != null)
            {
                UsherTokenReply = await GetUsherToken();

                string m3u8text = await GetM3U8TextByVodId();

                M3u8list = await GetM3U8ListFromM3U8Text(m3u8text);

                int? fps = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).Fps;
                string resolution = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).Resolution;
                string qualityId = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).QualityId;

                M3U8 selectedM3U8 = GetSelectedM3U8(fps, resolution, qualityId);


                List<string> playlistfiles = await GetPlaylistFromM3U(selectedM3U8, qualityId);

                var command = container.GetInstance<DownloadFileCommand>();

                List<TwitchDownload> downloadParameters = await GetDownloadsFromPlaylist(playlistfiles, selectedM3U8.Url, textBoxFolder.Text, selectedM3U8.Name, qualityId);


            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();

        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {


            cts = new CancellationTokenSource();
            buttonDownload.Enabled = false;
            toolStripStatusLabelStatus.Text = "starting download";
            try
            {
                if (Vodinfo != null)
                {
                    UsherTokenReply = await GetUsherToken();

                    string m3u8text = await GetM3U8TextByVodId();

                    M3u8list = await GetM3U8ListFromM3U8Text(m3u8text);

                    int? fps = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).Fps;
                    string resolution = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).Resolution;
                    string qualityId = ((TwitchVideoQuality)comboBoxQuality.SelectedItem).QualityId;

                    M3U8 selectedM3U8 = GetSelectedM3U8(fps, resolution, qualityId);


                    List<string> playlistfiles = await GetPlaylistFromM3U(selectedM3U8, qualityId);

                    var command = container.GetInstance<DownloadFileCommand>();

                    List<TwitchDownload> downloadParameters = await GetDownloadsFromPlaylist(playlistfiles, selectedM3U8.Url, textBoxFolder.Text, selectedM3U8.Name, qualityId);

                    DateTime datestamp;

                    command.Createfile = true;


                    foreach (TwitchDownload download in downloadParameters)
                    {

                        command.Url = download.DownloadParameters.Url;
                        command.Folder = download.Folder;
                        command.Filename = download.DownloadParameters.Filename;
                        command.CreateSubfolder = (checkBoxUseTitle.Checked || checkBoxUseDate.Checked);


                        if (checkBoxUseDate.Checked && DateTime.TryParse(textBoxVodDate.Text, out datestamp))
                        {
                            command.SubFolderName = datestamp.ToString("yyyyMMddHHmmss");
                        }
                        if (checkBoxUseTitle.Checked)
                        {
                            command.SubFolderName += " " + textBoxVodTitle.Text;
                        }


                        command.AppendToFile = (checkBoxUseffmpeg.Checked || checkBoxUseCopy.Checked);

                        if (command.AppendToFile)
                        {
                            command.AppendFileName = textBoxVodTitle.Text;
                            if (command.Filename.Contains("."))
                            {
                                string ext = command.Filename.Split('.')[1];
                                command.AppendFileName += "." + ext;

                            }
                        }

                        downloadFileCommandHandler.ProgressChanged += Command_ProgressChanged;
                        // await downloadFileCommandHandler.

                        downloadFileCommandHandler.Token = cts.Token;

                        await downloadFileCommandHandler.HandleAsync(command);
                        //just get the first file.
                        //break;
                    }

                    //toolStripStatusLabelSpacerLeft.Text = "starting download";




                }

            }
            catch (OperationCanceledException ex)
            {


                toolStripStatusLabelStatus.Text = "download cancelled.";
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "download failed.";
            }

            toolStripProgressBar1.Value = 0;

            buttonDownload.Enabled = true;

        }

        private async Task<List<string>> GetPlaylistFromM3U(M3U8 selectedM3U8, string qualityId)
        {



            var queryM3UText = container.GetInstance<GetTwitchM3UTextQuery>();
            queryM3UText.Url = selectedM3U8.Url.Replace(selectedM3U8.Name, qualityId);

            string text = await getM3UTextQueryHandler.HandleAsync(queryM3UText);

            var queryM3U = container.GetInstance<GetTwitchM3UQuery>();

            queryM3U.BaseUrl = selectedM3U8.Url;
            queryM3U.Text = text;


            M3U m3u = await getM3UQueryHandler.HandleAsync(queryM3U);


            return m3u.Playlist;

        }

        private M3U8 GetSelectedM3U8(int? fps, string resolution, string qualityId)

        {
            return M3u8list.Where(x => x.Fps == fps && x.Resolution == resolution).FirstOrDefault();
        }
        public async Task<List<TwitchDownload>> GetDownloadsFromPlaylist(List<string> playlist, string url, string folder, string sourcequality, string quality)
        {



            GetTwitchDownloadQuery getTwitchDownloadQuery = container.GetInstance<GetTwitchDownloadQuery>();

            getTwitchDownloadQuery.Playlist = playlist;
            getTwitchDownloadQuery.Url = url;
            getTwitchDownloadQuery.Folder = folder;
            getTwitchDownloadQuery.SourceQuality = sourcequality;
            getTwitchDownloadQuery.DestinationQuality = quality;
            getTwitchDownloadQuery.Url = url;

            List<TwitchDownload> downloads = await getTwitchDownloadQueryHandler.HandleAsync(getTwitchDownloadQuery);

            return downloads;


        }
        private void Command_ProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
        {

            try
            {
                toolStripStatusLabelStatus.Text = totalBytesDownloaded + @"/" + totalFileSize + " bytes downloaded (" + Math.Round((double)progressPercentage) + @"%)";


                toolStripProgressBar1.ProgressBar.Value = (int)Math.Round((double)progressPercentage);

            }

            catch (Exception ex)
            {

            }

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxUseffmpeg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseCopy.Checked && checkBoxUseffmpeg.Checked)
            {

                checkBoxUseCopy.Checked = false;
            }

        }

        private void checkBoxUseCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseCopy.Checked && checkBoxUseffmpeg.Checked)
            {

                checkBoxUseffmpeg.Checked = false;
            }
        }
    }
}
