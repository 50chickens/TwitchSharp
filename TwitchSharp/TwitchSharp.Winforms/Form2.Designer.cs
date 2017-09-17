namespace TwitchSharp.Winforms
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuredStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLiveStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genericsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSearchByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodInfoByUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m38UQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getM38UByVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usherTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getUsherTokenUsingVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLocalDB = new System.Windows.Forms.TabPage();
            this.tblConfigDataGridView = new System.Windows.Forms.DataGridView();
            this.tblConfigBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblConfigBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageWebService = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageWebApi = new System.Windows.Forms.TabPage();
            this.textBoxWebApi = new System.Windows.Forms.TextBox();
            this.tabPageWebApiUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewWebApiUsers = new System.Windows.Forms.DataGridView();
            this.tabPageWHMCSUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewWHMCSUsers = new System.Windows.Forms.DataGridView();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.tabPageWHMCSTestPlans = new System.Windows.Forms.TabPage();
            this.dataGridViewWhmcsPlans = new System.Windows.Forms.DataGridView();
            this.gamePokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLocalDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblConfigDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConfigBindingNavigator)).BeginInit();
            this.tblConfigBindingNavigator.SuspendLayout();
            this.tabPageWebService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageWebApi.SuspendLayout();
            this.tabPageWebApiUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWebApiUsers)).BeginInit();
            this.tabPageWHMCSUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWHMCSUsers)).BeginInit();
            this.tabPageTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageLogs.SuspendLayout();
            this.tabPageWHMCSTestPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhmcsPlans)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.twitchClientToolStripMenuItem,
            this.genericsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.vodsToolStripMenuItem,
            this.m38UQueryToolStripMenuItem,
            this.usherTokenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
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
            this.featuredStreamsToolStripMenuItem,
            this.topStreamsToolStripMenuItem,
            this.topLiveStreamsToolStripMenuItem,
            this.topGamesToolStripMenuItem});
            this.twitchClientToolStripMenuItem.Name = "twitchClientToolStripMenuItem";
            this.twitchClientToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.twitchClientToolStripMenuItem.Text = "TwitchClient";
            // 
            // featuredStreamsToolStripMenuItem
            // 
            this.featuredStreamsToolStripMenuItem.Name = "featuredStreamsToolStripMenuItem";
            this.featuredStreamsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.featuredStreamsToolStripMenuItem.Text = "FeaturedStreams";
            this.featuredStreamsToolStripMenuItem.Click += new System.EventHandler(this.featuredStreamsToolStripMenuItem_Click);
            // 
            // topStreamsToolStripMenuItem
            // 
            this.topStreamsToolStripMenuItem.Name = "topStreamsToolStripMenuItem";
            this.topStreamsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.topStreamsToolStripMenuItem.Text = "TopVideos";
            this.topStreamsToolStripMenuItem.Click += new System.EventHandler(this.topVideosToolStripMenuItem_Click);
            // 
            // topLiveStreamsToolStripMenuItem
            // 
            this.topLiveStreamsToolStripMenuItem.Name = "topLiveStreamsToolStripMenuItem";
            this.topLiveStreamsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.topLiveStreamsToolStripMenuItem.Text = "TopLiveStreams";
            this.topLiveStreamsToolStripMenuItem.Click += new System.EventHandler(this.topLiveStreamsToolStripMenuItem_Click);
            // 
            // topGamesToolStripMenuItem
            // 
            this.topGamesToolStripMenuItem.Name = "topGamesToolStripMenuItem";
            this.topGamesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.topGamesToolStripMenuItem.Text = "TopGames";
            this.topGamesToolStripMenuItem.Click += new System.EventHandler(this.topGamesToolStripMenuItem_Click);
            // 
            // genericsToolStripMenuItem
            // 
            this.genericsToolStripMenuItem.Name = "genericsToolStripMenuItem";
            this.genericsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelSearchToolStripMenuItem,
            this.channelSearchByIdToolStripMenuItem});
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
            this.channelSearchByIdToolStripMenuItem.Text = "ChannelSearchById";
            this.channelSearchByIdToolStripMenuItem.Click += new System.EventHandler(this.channelSearchByIdToolStripMenuItem_Click);
            // 
            // vodsToolStripMenuItem
            // 
            this.vodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vodInfoByUrlToolStripMenuItem});
            this.vodsToolStripMenuItem.Name = "vodsToolStripMenuItem";
            this.vodsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vodsToolStripMenuItem.Text = "Vods";
            // 
            // vodInfoByUrlToolStripMenuItem
            // 
            this.vodInfoByUrlToolStripMenuItem.Name = "vodInfoByUrlToolStripMenuItem";
            this.vodInfoByUrlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vodInfoByUrlToolStripMenuItem.Text = "VodInfoByUrl";
            this.vodInfoByUrlToolStripMenuItem.Click += new System.EventHandler(this.vodInfoByUrlToolStripMenuItem_Click);
            // 
            // m38UQueryToolStripMenuItem
            // 
            this.m38UQueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getM38UByVodIdToolStripMenuItem});
            this.m38UQueryToolStripMenuItem.Name = "m38UQueryToolStripMenuItem";
            this.m38UQueryToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.m38UQueryToolStripMenuItem.Text = "M38UQuery";
            // 
            // getM38UByVodIdToolStripMenuItem
            // 
            this.getM38UByVodIdToolStripMenuItem.Name = "getM38UByVodIdToolStripMenuItem";
            this.getM38UByVodIdToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.getM38UByVodIdToolStripMenuItem.Text = "GetM38UByVodId";
            this.getM38UByVodIdToolStripMenuItem.Click += new System.EventHandler(this.getM38UByVodIdToolStripMenuItem_Click);
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
            // createDictionaryToolStripMenuItem
            // 
            this.createDictionaryToolStripMenuItem.Name = "createDictionaryToolStripMenuItem";
            this.createDictionaryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLocalDB);
            this.tabControl1.Controls.Add(this.tabPageWebService);
            this.tabControl1.Controls.Add(this.tabPageWebApi);
            this.tabControl1.Controls.Add(this.tabPageWebApiUsers);
            this.tabControl1.Controls.Add(this.tabPageWHMCSUsers);
            this.tabControl1.Controls.Add(this.tabPageTests);
            this.tabControl1.Controls.Add(this.tabPageLogs);
            this.tabControl1.Controls.Add(this.tabPageWHMCSTestPlans);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 345);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageLocalDB
            // 
            this.tabPageLocalDB.Controls.Add(this.tblConfigDataGridView);
            this.tabPageLocalDB.Controls.Add(this.tblConfigBindingNavigator);
            this.tabPageLocalDB.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocalDB.Name = "tabPageLocalDB";
            this.tabPageLocalDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalDB.Size = new System.Drawing.Size(858, 319);
            this.tabPageLocalDB.TabIndex = 0;
            this.tabPageLocalDB.Text = "Local DB";
            this.tabPageLocalDB.UseVisualStyleBackColor = true;
            // 
            // tblConfigDataGridView
            // 
            this.tblConfigDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblConfigDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConfigDataGridView.Location = new System.Drawing.Point(3, 28);
            this.tblConfigDataGridView.Name = "tblConfigDataGridView";
            this.tblConfigDataGridView.Size = new System.Drawing.Size(852, 288);
            this.tblConfigDataGridView.TabIndex = 1;
            // 
            // tblConfigBindingNavigator
            // 
            this.tblConfigBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblConfigBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblConfigBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblConfigBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblConfigBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblConfigBindingNavigatorSaveItem});
            this.tblConfigBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tblConfigBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblConfigBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblConfigBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblConfigBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblConfigBindingNavigator.Name = "tblConfigBindingNavigator";
            this.tblConfigBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblConfigBindingNavigator.Size = new System.Drawing.Size(852, 25);
            this.tblConfigBindingNavigator.TabIndex = 0;
            this.tblConfigBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblConfigBindingNavigatorSaveItem
            // 
            this.tblConfigBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblConfigBindingNavigatorSaveItem.Name = "tblConfigBindingNavigatorSaveItem";
            this.tblConfigBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblConfigBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // tabPageWebService
            // 
            this.tabPageWebService.Controls.Add(this.dataGridView1);
            this.tabPageWebService.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebService.Name = "tabPageWebService";
            this.tabPageWebService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebService.Size = new System.Drawing.Size(858, 319);
            this.tabPageWebService.TabIndex = 1;
            this.tabPageWebService.Text = "Web Service";
            this.tabPageWebService.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 313);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabPageWebApi
            // 
            this.tabPageWebApi.Controls.Add(this.textBoxWebApi);
            this.tabPageWebApi.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebApi.Name = "tabPageWebApi";
            this.tabPageWebApi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebApi.Size = new System.Drawing.Size(858, 319);
            this.tabPageWebApi.TabIndex = 2;
            this.tabPageWebApi.Text = "Web API";
            this.tabPageWebApi.UseVisualStyleBackColor = true;
            // 
            // textBoxWebApi
            // 
            this.textBoxWebApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWebApi.Location = new System.Drawing.Point(3, 3);
            this.textBoxWebApi.Multiline = true;
            this.textBoxWebApi.Name = "textBoxWebApi";
            this.textBoxWebApi.Size = new System.Drawing.Size(852, 313);
            this.textBoxWebApi.TabIndex = 0;
            // 
            // tabPageWebApiUsers
            // 
            this.tabPageWebApiUsers.Controls.Add(this.dataGridViewWebApiUsers);
            this.tabPageWebApiUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebApiUsers.Name = "tabPageWebApiUsers";
            this.tabPageWebApiUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebApiUsers.Size = new System.Drawing.Size(858, 319);
            this.tabPageWebApiUsers.TabIndex = 6;
            this.tabPageWebApiUsers.Text = "Web Api Users";
            this.tabPageWebApiUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWebApiUsers
            // 
            this.dataGridViewWebApiUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWebApiUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWebApiUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWebApiUsers.Name = "dataGridViewWebApiUsers";
            this.dataGridViewWebApiUsers.Size = new System.Drawing.Size(852, 313);
            this.dataGridViewWebApiUsers.TabIndex = 0;
            // 
            // tabPageWHMCSUsers
            // 
            this.tabPageWHMCSUsers.Controls.Add(this.dataGridViewWHMCSUsers);
            this.tabPageWHMCSUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageWHMCSUsers.Name = "tabPageWHMCSUsers";
            this.tabPageWHMCSUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWHMCSUsers.Size = new System.Drawing.Size(858, 319);
            this.tabPageWHMCSUsers.TabIndex = 3;
            this.tabPageWHMCSUsers.Text = "WHMCS Users";
            this.tabPageWHMCSUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWHMCSUsers
            // 
            this.dataGridViewWHMCSUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWHMCSUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWHMCSUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWHMCSUsers.Name = "dataGridViewWHMCSUsers";
            this.dataGridViewWHMCSUsers.Size = new System.Drawing.Size(852, 313);
            this.dataGridViewWHMCSUsers.TabIndex = 0;
            // 
            // tabPageTests
            // 
            this.tabPageTests.Controls.Add(this.dataGridView2);
            this.tabPageTests.Location = new System.Drawing.Point(4, 22);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTests.Size = new System.Drawing.Size(858, 319);
            this.tabPageTests.TabIndex = 4;
            this.tabPageTests.Text = "Tests";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(852, 313);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.textBoxLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(858, 319);
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
            this.textBoxLogs.Size = new System.Drawing.Size(852, 313);
            this.textBoxLogs.TabIndex = 0;
            // 
            // tabPageWHMCSTestPlans
            // 
            this.tabPageWHMCSTestPlans.Controls.Add(this.dataGridViewWhmcsPlans);
            this.tabPageWHMCSTestPlans.Location = new System.Drawing.Point(4, 22);
            this.tabPageWHMCSTestPlans.Name = "tabPageWHMCSTestPlans";
            this.tabPageWHMCSTestPlans.Size = new System.Drawing.Size(858, 319);
            this.tabPageWHMCSTestPlans.TabIndex = 7;
            this.tabPageWHMCSTestPlans.Text = "Whmcs Plans";
            this.tabPageWHMCSTestPlans.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWhmcsPlans
            // 
            this.dataGridViewWhmcsPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWhmcsPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWhmcsPlans.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWhmcsPlans.Name = "dataGridViewWhmcsPlans";
            this.dataGridViewWhmcsPlans.Size = new System.Drawing.Size(858, 319);
            this.dataGridViewWhmcsPlans.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(866, 391);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
            this.tabPageLocalDB.ResumeLayout(false);
            this.tabPageLocalDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblConfigDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConfigBindingNavigator)).EndInit();
            this.tblConfigBindingNavigator.ResumeLayout(false);
            this.tblConfigBindingNavigator.PerformLayout();
            this.tabPageWebService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageWebApi.ResumeLayout(false);
            this.tabPageWebApi.PerformLayout();
            this.tabPageWebApiUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWebApiUsers)).EndInit();
            this.tabPageWHMCSUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWHMCSUsers)).EndInit();
            this.tabPageTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.tabPageWHMCSTestPlans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhmcsPlans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuredStreamsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem topStreamsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLocalDB;
        private System.Windows.Forms.DataGridView tblConfigDataGridView;
        private System.Windows.Forms.BindingNavigator tblConfigBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblConfigBindingNavigatorSaveItem;
        private System.Windows.Forms.TabPage tabPageWebService;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageWebApi;
        private System.Windows.Forms.TextBox textBoxWebApi;
        private System.Windows.Forms.TabPage tabPageWebApiUsers;
        private System.Windows.Forms.DataGridView dataGridViewWebApiUsers;
        private System.Windows.Forms.TabPage tabPageWHMCSUsers;
        private System.Windows.Forms.DataGridView dataGridViewWHMCSUsers;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.TabPage tabPageWHMCSTestPlans;
        private System.Windows.Forms.DataGridView dataGridViewWhmcsPlans;
        private System.Windows.Forms.ToolStripMenuItem topLiveStreamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genericsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelSearchByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodInfoByUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m38UQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getM38UByVodIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usherTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getUsherTokenUsingVodIdToolStripMenuItem;
    }
}

