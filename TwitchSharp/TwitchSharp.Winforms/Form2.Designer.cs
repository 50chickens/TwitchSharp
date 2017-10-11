﻿namespace TwitchSharp.Winforms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLiveStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSearchByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelVideosByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodInfoByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m38UQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getM38UByVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getM3U8FromM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTSPiecesFromM3U8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuM3UVodInfoById = new System.Windows.Forms.ToolStripMenuItem();
            this.usherTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getUsherTokenUsingVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseQualitiesFromVodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTwitchChannelName = new System.Windows.Forms.TextBox();
            this.labelChannelName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonGetChart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTwitchChannelId = new System.Windows.Forms.Label();
            this.textBoxTwitchChannelId = new System.Windows.Forms.TextBox();
            this.groupBoxChartProperties = new System.Windows.Forms.GroupBox();
            this.textBoxVodGame = new System.Windows.Forms.TextBox();
            this.labelVodGame = new System.Windows.Forms.Label();
            this.textBoxVodViews = new System.Windows.Forms.TextBox();
            this.textBoxVodLength = new System.Windows.Forms.TextBox();
            this.labelVodViews = new System.Windows.Forms.Label();
            this.labelVodLength = new System.Windows.Forms.Label();
            this.textBoxVodDate = new System.Windows.Forms.TextBox();
            this.textBoxVodTitle = new System.Windows.Forms.TextBox();
            this.labelVodDate = new System.Windows.Forms.Label();
            this.labelVodTitle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.buttonGetVodInfo = new System.Windows.Forms.Button();
            this.textBoxTwitchUrl = new System.Windows.Forms.TextBox();
            this.labelTwitchUrl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.tabPagePoller = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.gamePokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxChartProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagePoller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.twitchClientToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.vodsToolStripMenuItem,
            this.m38UQueryToolStripMenuItem,
            this.usherTokenToolStripMenuItem,
            this.qualitiesToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // twitchClientToolStripMenuItem
            // 
            this.twitchClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topStreamsToolStripMenuItem,
            this.topLiveStreamsToolStripMenuItem,
            this.topGamesToolStripMenuItem});
            this.twitchClientToolStripMenuItem.Name = "twitchClientToolStripMenuItem";
            this.twitchClientToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.twitchClientToolStripMenuItem.Text = "TwitchClient";
            // 
            // topStreamsToolStripMenuItem
            // 
            this.topStreamsToolStripMenuItem.Name = "topStreamsToolStripMenuItem";
            this.topStreamsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.topStreamsToolStripMenuItem.Text = "TopVideos";
            this.topStreamsToolStripMenuItem.Click += new System.EventHandler(this.topVideosToolStripMenuItem_Click);
            // 
            // topLiveStreamsToolStripMenuItem
            // 
            this.topLiveStreamsToolStripMenuItem.Name = "topLiveStreamsToolStripMenuItem";
            this.topLiveStreamsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.topLiveStreamsToolStripMenuItem.Text = "TopLiveStreams";
            this.topLiveStreamsToolStripMenuItem.Click += new System.EventHandler(this.topLiveStreamsToolStripMenuItem_Click);
            // 
            // topGamesToolStripMenuItem
            // 
            this.topGamesToolStripMenuItem.Name = "topGamesToolStripMenuItem";
            this.topGamesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.topGamesToolStripMenuItem.Text = "TopGames";
            this.topGamesToolStripMenuItem.Click += new System.EventHandler(this.topGamesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelSearchToolStripMenuItem,
            this.channelSearchByIdToolStripMenuItem,
            this.channelVideosByIdToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // channelSearchToolStripMenuItem
            // 
            this.channelSearchToolStripMenuItem.Name = "channelSearchToolStripMenuItem";
            this.channelSearchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.channelSearchToolStripMenuItem.Text = "ChannelSearch";
            this.channelSearchToolStripMenuItem.Click += new System.EventHandler(this.channelSearchToolStripMenuItem_Click);
            // 
            // channelSearchByIdToolStripMenuItem
            // 
            this.channelSearchByIdToolStripMenuItem.Name = "channelSearchByIdToolStripMenuItem";
            this.channelSearchByIdToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.channelSearchByIdToolStripMenuItem.Text = "ChannelInfoById";
            this.channelSearchByIdToolStripMenuItem.Click += new System.EventHandler(this.channelInfoToolStripMenuItem_Click);
            // 
            // channelVideosByIdToolStripMenuItem
            // 
            this.channelVideosByIdToolStripMenuItem.Name = "channelVideosByIdToolStripMenuItem";
            this.channelVideosByIdToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.channelVideosByIdToolStripMenuItem.Text = "ChannelVideosById";
            this.channelVideosByIdToolStripMenuItem.Click += new System.EventHandler(this.channelVideosByIdToolStripMenuItem_Click);
            // 
            // vodsToolStripMenuItem
            // 
            this.vodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vodInfoByIdToolStripMenuItem});
            this.vodsToolStripMenuItem.Name = "vodsToolStripMenuItem";
            this.vodsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vodsToolStripMenuItem.Text = "Vods";
            // 
            // vodInfoByIdToolStripMenuItem
            // 
            this.vodInfoByIdToolStripMenuItem.Name = "vodInfoByIdToolStripMenuItem";
            this.vodInfoByIdToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.vodInfoByIdToolStripMenuItem.Text = "VodInfoById";
            this.vodInfoByIdToolStripMenuItem.Click += new System.EventHandler(this.vodInfoByIdToolStripMenuItem_Click);
            // 
            // m38UQueryToolStripMenuItem
            // 
            this.m38UQueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getM38UByVodIdToolStripMenuItem,
            this.getM3U8FromM3UToolStripMenuItem,
            this.getTSPiecesFromM3U8ToolStripMenuItem,
            this.toolStripMenuM3UVodInfoById});
            this.m38UQueryToolStripMenuItem.Name = "m38UQueryToolStripMenuItem";
            this.m38UQueryToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.m38UQueryToolStripMenuItem.Text = "M38UQuery";
            // 
            // getM38UByVodIdToolStripMenuItem
            // 
            this.getM38UByVodIdToolStripMenuItem.Name = "getM38UByVodIdToolStripMenuItem";
            this.getM38UByVodIdToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getM38UByVodIdToolStripMenuItem.Text = "GetM38UByVodId";
            this.getM38UByVodIdToolStripMenuItem.Click += new System.EventHandler(this.getM38ByVodIdToolStripMenuItem_Click);
            // 
            // getM3U8FromM3UToolStripMenuItem
            // 
            this.getM3U8FromM3UToolStripMenuItem.Name = "getM3U8FromM3UToolStripMenuItem";
            this.getM3U8FromM3UToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getM3U8FromM3UToolStripMenuItem.Text = "GetM3U8FromM3U";
            this.getM3U8FromM3UToolStripMenuItem.Click += new System.EventHandler(this.loadM3U8ToolStripMenuItem_Click);
            // 
            // getTSPiecesFromM3U8ToolStripMenuItem
            // 
            this.getTSPiecesFromM3U8ToolStripMenuItem.Enabled = false;
            this.getTSPiecesFromM3U8ToolStripMenuItem.Name = "getTSPiecesFromM3U8ToolStripMenuItem";
            this.getTSPiecesFromM3U8ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getTSPiecesFromM3U8ToolStripMenuItem.Text = "GetTSPiecesFromM3U8";
            this.getTSPiecesFromM3U8ToolStripMenuItem.Click += new System.EventHandler(this.getTSPiecesFromM3U8ToolStripMenuItem_Click);
            // 
            // toolStripMenuM3UVodInfoById
            // 
            this.toolStripMenuM3UVodInfoById.Name = "toolStripMenuM3UVodInfoById";
            this.toolStripMenuM3UVodInfoById.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuM3UVodInfoById.Text = "VodInfoById";
            this.toolStripMenuM3UVodInfoById.Click += new System.EventHandler(this.toolStripMenuM3UVodInfoById_Click);
            // 
            // usherTokenToolStripMenuItem
            // 
            this.usherTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getUsherTokenUsingVodIdToolStripMenuItem});
            this.usherTokenToolStripMenuItem.Name = "usherTokenToolStripMenuItem";
            this.usherTokenToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.usherTokenToolStripMenuItem.Text = "UsherToken";
            // 
            // getUsherTokenUsingVodIdToolStripMenuItem
            // 
            this.getUsherTokenUsingVodIdToolStripMenuItem.Name = "getUsherTokenUsingVodIdToolStripMenuItem";
            this.getUsherTokenUsingVodIdToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.getUsherTokenUsingVodIdToolStripMenuItem.Text = "GetUsherTokenUsingVodId";
            this.getUsherTokenUsingVodIdToolStripMenuItem.Click += new System.EventHandler(this.getUsherTokenUsingVodIdToolStripMenuItem_Click);
            // 
            // qualitiesToolStripMenuItem
            // 
            this.qualitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseQualitiesFromVodToolStripMenuItem});
            this.qualitiesToolStripMenuItem.Name = "qualitiesToolStripMenuItem";
            this.qualitiesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.qualitiesToolStripMenuItem.Text = "Qualities";
            // 
            // parseQualitiesFromVodToolStripMenuItem
            // 
            this.parseQualitiesFromVodToolStripMenuItem.Name = "parseQualitiesFromVodToolStripMenuItem";
            this.parseQualitiesFromVodToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.parseQualitiesFromVodToolStripMenuItem.Text = "Load Qualities From Vod";
            this.parseQualitiesFromVodToolStripMenuItem.Click += new System.EventHandler(this.parseQualitiesFromVodToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vodToolStripMenuItem});
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // vodToolStripMenuItem
            // 
            this.vodToolStripMenuItem.Name = "vodToolStripMenuItem";
            this.vodToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // createDictionaryToolStripMenuItem
            // 
            this.createDictionaryToolStripMenuItem.Name = "createDictionaryToolStripMenuItem";
            this.createDictionaryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 27);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 22);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(144, 22);
            this.toolStripStatusLabelStatus.Text = "toolStripStatusLabelStatus";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(618, 22);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 21);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Controls.Add(this.tabPagePoller);
            this.tabControl1.Controls.Add(this.tabPageLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 465);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSearch.Controls.Add(this.groupBox4);
            this.tabPageSearch.Controls.Add(this.groupBoxChartProperties);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(871, 439);
            this.tabPageSearch.TabIndex = 6;
            this.tabPageSearch.Text = "Search";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.textBoxTwitchChannelName);
            this.groupBox4.Controls.Add(this.labelChannelName);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.buttonGetChart);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.labelTwitchChannelId);
            this.groupBox4.Controls.Add(this.textBoxTwitchChannelId);
            this.groupBox4.Location = new System.Drawing.Point(404, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 423);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vod Search Options";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(412, 290);
            this.dataGridView1.TabIndex = 18;
            // 
            // textBoxTwitchChannelName
            // 
            this.textBoxTwitchChannelName.Location = new System.Drawing.Point(115, 33);
            this.textBoxTwitchChannelName.Name = "textBoxTwitchChannelName";
            this.textBoxTwitchChannelName.Size = new System.Drawing.Size(244, 20);
            this.textBoxTwitchChannelName.TabIndex = 12;
            // 
            // labelChannelName
            // 
            this.labelChannelName.AutoSize = true;
            this.labelChannelName.Location = new System.Drawing.Point(29, 36);
            this.labelChannelName.Name = "labelChannelName";
            this.labelChannelName.Size = new System.Drawing.Size(80, 13);
            this.labelChannelName.TabIndex = 3;
            this.labelChannelName.Text = "Channel Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 20);
            this.textBox4.TabIndex = 17;
            // 
            // buttonGetChart
            // 
            this.buttonGetChart.Enabled = false;
            this.buttonGetChart.Location = new System.Drawing.Point(365, 33);
            this.buttonGetChart.Name = "buttonGetChart";
            this.buttonGetChart.Size = new System.Drawing.Size(79, 73);
            this.buttonGetChart.TabIndex = 5;
            this.buttonGetChart.Text = "Get Vods";
            this.buttonGetChart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Game Name:";
            // 
            // labelTwitchChannelId
            // 
            this.labelTwitchChannelId.AutoSize = true;
            this.labelTwitchChannelId.Location = new System.Drawing.Point(48, 63);
            this.labelTwitchChannelId.Name = "labelTwitchChannelId";
            this.labelTwitchChannelId.Size = new System.Drawing.Size(61, 13);
            this.labelTwitchChannelId.TabIndex = 13;
            this.labelTwitchChannelId.Text = "Channel Id:";
            // 
            // textBoxTwitchChannelId
            // 
            this.textBoxTwitchChannelId.Location = new System.Drawing.Point(115, 60);
            this.textBoxTwitchChannelId.Name = "textBoxTwitchChannelId";
            this.textBoxTwitchChannelId.Size = new System.Drawing.Size(244, 20);
            this.textBoxTwitchChannelId.TabIndex = 14;
            // 
            // groupBoxChartProperties
            // 
            this.groupBoxChartProperties.Controls.Add(this.textBoxVodGame);
            this.groupBoxChartProperties.Controls.Add(this.labelVodGame);
            this.groupBoxChartProperties.Controls.Add(this.textBoxVodViews);
            this.groupBoxChartProperties.Controls.Add(this.textBoxVodLength);
            this.groupBoxChartProperties.Controls.Add(this.labelVodViews);
            this.groupBoxChartProperties.Controls.Add(this.labelVodLength);
            this.groupBoxChartProperties.Controls.Add(this.textBoxVodDate);
            this.groupBoxChartProperties.Controls.Add(this.textBoxVodTitle);
            this.groupBoxChartProperties.Controls.Add(this.labelVodDate);
            this.groupBoxChartProperties.Controls.Add(this.labelVodTitle);
            this.groupBoxChartProperties.Controls.Add(this.button4);
            this.groupBoxChartProperties.Controls.Add(this.pictureBox1);
            this.groupBoxChartProperties.Controls.Add(this.labelFolder);
            this.groupBoxChartProperties.Controls.Add(this.textBox6);
            this.groupBoxChartProperties.Controls.Add(this.labelQuality);
            this.groupBoxChartProperties.Controls.Add(this.comboBoxQuality);
            this.groupBoxChartProperties.Controls.Add(this.buttonGetVodInfo);
            this.groupBoxChartProperties.Controls.Add(this.textBoxTwitchUrl);
            this.groupBoxChartProperties.Controls.Add(this.labelTwitchUrl);
            this.groupBoxChartProperties.Controls.Add(this.button3);
            this.groupBoxChartProperties.Controls.Add(this.button2);
            this.groupBoxChartProperties.Location = new System.Drawing.Point(8, 6);
            this.groupBoxChartProperties.Name = "groupBoxChartProperties";
            this.groupBoxChartProperties.Size = new System.Drawing.Size(390, 423);
            this.groupBoxChartProperties.TabIndex = 8;
            this.groupBoxChartProperties.TabStop = false;
            this.groupBoxChartProperties.Text = "Vod Search Options";
            // 
            // textBoxVodGame
            // 
            this.textBoxVodGame.Location = new System.Drawing.Point(70, 82);
            this.textBoxVodGame.Name = "textBoxVodGame";
            this.textBoxVodGame.ReadOnly = true;
            this.textBoxVodGame.Size = new System.Drawing.Size(311, 20);
            this.textBoxVodGame.TabIndex = 41;
            // 
            // labelVodGame
            // 
            this.labelVodGame.AutoSize = true;
            this.labelVodGame.Location = new System.Drawing.Point(24, 86);
            this.labelVodGame.Name = "labelVodGame";
            this.labelVodGame.Size = new System.Drawing.Size(38, 13);
            this.labelVodGame.TabIndex = 40;
            this.labelVodGame.Text = "Game:";
            // 
            // textBoxVodViews
            // 
            this.textBoxVodViews.Location = new System.Drawing.Point(70, 129);
            this.textBoxVodViews.Name = "textBoxVodViews";
            this.textBoxVodViews.ReadOnly = true;
            this.textBoxVodViews.Size = new System.Drawing.Size(109, 20);
            this.textBoxVodViews.TabIndex = 39;
            // 
            // textBoxVodLength
            // 
            this.textBoxVodLength.Location = new System.Drawing.Point(239, 129);
            this.textBoxVodLength.Name = "textBoxVodLength";
            this.textBoxVodLength.ReadOnly = true;
            this.textBoxVodLength.Size = new System.Drawing.Size(142, 20);
            this.textBoxVodLength.TabIndex = 38;
            // 
            // labelVodViews
            // 
            this.labelVodViews.AutoSize = true;
            this.labelVodViews.Location = new System.Drawing.Point(24, 132);
            this.labelVodViews.Name = "labelVodViews";
            this.labelVodViews.Size = new System.Drawing.Size(38, 13);
            this.labelVodViews.TabIndex = 37;
            this.labelVodViews.Text = "Views:";
            // 
            // labelVodLength
            // 
            this.labelVodLength.AutoSize = true;
            this.labelVodLength.Location = new System.Drawing.Point(190, 132);
            this.labelVodLength.Name = "labelVodLength";
            this.labelVodLength.Size = new System.Drawing.Size(43, 13);
            this.labelVodLength.TabIndex = 36;
            this.labelVodLength.Text = "Length:";
            // 
            // textBoxVodDate
            // 
            this.textBoxVodDate.Location = new System.Drawing.Point(70, 105);
            this.textBoxVodDate.Name = "textBoxVodDate";
            this.textBoxVodDate.ReadOnly = true;
            this.textBoxVodDate.Size = new System.Drawing.Size(311, 20);
            this.textBoxVodDate.TabIndex = 35;
            // 
            // textBoxVodTitle
            // 
            this.textBoxVodTitle.Location = new System.Drawing.Point(70, 59);
            this.textBoxVodTitle.Name = "textBoxVodTitle";
            this.textBoxVodTitle.ReadOnly = true;
            this.textBoxVodTitle.Size = new System.Drawing.Size(311, 20);
            this.textBoxVodTitle.TabIndex = 34;
            // 
            // labelVodDate
            // 
            this.labelVodDate.AutoSize = true;
            this.labelVodDate.Location = new System.Drawing.Point(9, 108);
            this.labelVodDate.Name = "labelVodDate";
            this.labelVodDate.Size = new System.Drawing.Size(55, 13);
            this.labelVodDate.TabIndex = 32;
            this.labelVodDate.Text = "Vod Date:";
            // 
            // labelVodTitle
            // 
            this.labelVodTitle.AutoSize = true;
            this.labelVodTitle.Location = new System.Drawing.Point(12, 63);
            this.labelVodTitle.Name = "labelVodTitle";
            this.labelVodTitle.Size = new System.Drawing.Size(52, 13);
            this.labelVodTitle.TabIndex = 31;
            this.labelVodTitle.Text = "Vod Title:";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(265, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(12, 392);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(39, 13);
            this.labelFolder.TabIndex = 29;
            this.labelFolder.Text = "Folder:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(57, 392);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(195, 20);
            this.textBox6.TabIndex = 27;
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(12, 353);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(42, 13);
            this.labelQuality.TabIndex = 28;
            this.labelQuality.Text = "Quality:";
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.Enabled = false;
            this.comboBoxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Location = new System.Drawing.Point(60, 350);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(192, 21);
            this.comboBoxQuality.TabIndex = 26;
            // 
            // buttonGetVodInfo
            // 
            this.buttonGetVodInfo.Enabled = false;
            this.buttonGetVodInfo.Location = new System.Drawing.Point(318, 33);
            this.buttonGetVodInfo.Name = "buttonGetVodInfo";
            this.buttonGetVodInfo.Size = new System.Drawing.Size(63, 22);
            this.buttonGetVodInfo.TabIndex = 24;
            this.buttonGetVodInfo.Text = "Get Vod";
            this.buttonGetVodInfo.UseVisualStyleBackColor = true;
            this.buttonGetVodInfo.Click += new System.EventHandler(this.buttonVodInfo_Click);
            // 
            // textBoxTwitchUrl
            // 
            this.textBoxTwitchUrl.Location = new System.Drawing.Point(70, 34);
            this.textBoxTwitchUrl.Name = "textBoxTwitchUrl";
            this.textBoxTwitchUrl.Size = new System.Drawing.Size(236, 20);
            this.textBoxTwitchUrl.TabIndex = 23;
            this.textBoxTwitchUrl.TextChanged += new System.EventHandler(this.textBoxTwitchUrl_TextChanged);
            // 
            // labelTwitchUrl
            // 
            this.labelTwitchUrl.AutoSize = true;
            this.labelTwitchUrl.Location = new System.Drawing.Point(6, 38);
            this.labelTwitchUrl.Name = "labelTwitchUrl";
            this.labelTwitchUrl.Size = new System.Drawing.Size(58, 13);
            this.labelTwitchUrl.TabIndex = 22;
            this.labelTwitchUrl.Text = "Twitch Url:";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(265, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Add to Queue";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(312, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(871, 439);
            this.tabPageResults.TabIndex = 8;
            this.tabPageResults.Text = "Search Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // tabPagePoller
            // 
            this.tabPagePoller.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePoller.Controls.Add(this.dataGridView2);
            this.tabPagePoller.Controls.Add(this.groupBox1);
            this.tabPagePoller.Location = new System.Drawing.Point(4, 22);
            this.tabPagePoller.Name = "tabPagePoller";
            this.tabPagePoller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePoller.Size = new System.Drawing.Size(871, 439);
            this.tabPagePoller.TabIndex = 7;
            this.tabPagePoller.Text = "Poller";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(403, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 301);
            this.dataGridView2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vod Search Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Game Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Vods";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Channel Id:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Channel Name:";
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.textBoxLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(871, 439);
            this.tabPageLogs.TabIndex = 5;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogs.Location = new System.Drawing.Point(3, 3);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.Size = new System.Drawing.Size(865, 433);
            this.textBoxLogs.TabIndex = 0;
            // 
            // gamePokerToolStripMenuItem
            // 
            this.gamePokerToolStripMenuItem.Name = "gamePokerToolStripMenuItem";
            this.gamePokerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxChartProperties.ResumeLayout(false);
            this.groupBoxChartProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagePoller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelSearchByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodInfoByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m38UQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getM38UByVodIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usherTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getUsherTokenUsingVodIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topStreamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLiveStreamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelVideosByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getM3U8FromM3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTSPiecesFromM3U8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuM3UVodInfoById;
        private System.Windows.Forms.ToolStripMenuItem qualitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseQualitiesFromVodToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.GroupBox groupBoxChartProperties;
        private System.Windows.Forms.TextBox textBoxTwitchChannelId;
        private System.Windows.Forms.Label labelTwitchChannelId;
        private System.Windows.Forms.TextBox textBoxTwitchChannelName;
        private System.Windows.Forms.Label labelChannelName;
        private System.Windows.Forms.TabPage tabPagePoller;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetChart;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Button buttonGetVodInfo;
        private System.Windows.Forms.TextBox textBoxTwitchUrl;
        private System.Windows.Forms.Label labelTwitchUrl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVodViews;
        private System.Windows.Forms.TextBox textBoxVodLength;
        private System.Windows.Forms.Label labelVodViews;
        private System.Windows.Forms.Label labelVodLength;
        private System.Windows.Forms.TextBox textBoxVodDate;
        private System.Windows.Forms.TextBox textBoxVodTitle;
        private System.Windows.Forms.Label labelVodDate;
        private System.Windows.Forms.Label labelVodTitle;
        private System.Windows.Forms.TextBox textBoxVodGame;
        private System.Windows.Forms.Label labelVodGame;
    }
}

