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
            this.vodInfoByUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m38UQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getM38UByVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usherTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getUsherTokenUsingVodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.gamePokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getM3U8FromM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.vodInfoByUrlToolStripMenuItem});
            this.vodsToolStripMenuItem.Name = "vodsToolStripMenuItem";
            this.vodsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vodsToolStripMenuItem.Text = "Vods";
            // 
            // vodInfoByUrlToolStripMenuItem
            // 
            this.vodInfoByUrlToolStripMenuItem.Name = "vodInfoByUrlToolStripMenuItem";
            this.vodInfoByUrlToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.vodInfoByUrlToolStripMenuItem.Text = "VodInfoByUrl";
            this.vodInfoByUrlToolStripMenuItem.Click += new System.EventHandler(this.vodInfoByUrlToolStripMenuItem_Click);
            // 
            // m38UQueryToolStripMenuItem
            // 
            this.m38UQueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getM38UByVodIdToolStripMenuItem,
            this.getM3U8FromM3UToolStripMenuItem});
            this.m38UQueryToolStripMenuItem.Name = "m38UQueryToolStripMenuItem";
            this.m38UQueryToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.m38UQueryToolStripMenuItem.Text = "M38UQuery";
            // 
            // getM38UByVodIdToolStripMenuItem
            // 
            this.getM38UByVodIdToolStripMenuItem.Name = "getM38UByVodIdToolStripMenuItem";
            this.getM38UByVodIdToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.getM38UByVodIdToolStripMenuItem.Text = "GetM38UByVodId";
            this.getM38UByVodIdToolStripMenuItem.Click += new System.EventHandler(this.getM38ByVodIdToolStripMenuItem_Click);
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
            this.tabControl1.Controls.Add(this.tabPageLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 345);
            this.tabControl1.TabIndex = 5;
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
            // gamePokerToolStripMenuItem
            // 
            this.gamePokerToolStripMenuItem.Name = "gamePokerToolStripMenuItem";
            this.gamePokerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // getM3U8FromM3UToolStripMenuItem
            // 
            this.getM3U8FromM3UToolStripMenuItem.Name = "getM3U8FromM3UToolStripMenuItem";
            this.getM3U8FromM3UToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.getM3U8FromM3UToolStripMenuItem.Text = "GetM3U8FromM3U";
            this.getM3U8FromM3UToolStripMenuItem.Click += new System.EventHandler(this.loadM3U8ToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem vodInfoByUrlToolStripMenuItem;
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
    }
}

