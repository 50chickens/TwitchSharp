using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

namespace TwitchSharp.Winforms
{
    public partial class Form1 : Form
    {

        SimpleInjector.Container container;



        private ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos> getTwitchTopVideosQueryHandler;
        private ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams> getTwitchLiveStreamsQueryHandler;
        private ITwitchQueryHandler<GetTwitchTopGamesQuery, TopGames> getTwitchTopGamesQueryHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void topVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {


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


            container.Register<ITwitchClient, TwitchClient>();
            container.Register<ITwitchHttpClient, TwitchHttpClient>(SimpleInjector.Lifestyle.Singleton);
            container.Register<ITwitchQueryOptions>(() => OptionFactory.Create<TwitchQueryOptions>(twitchQueryOptionsJson), SimpleInjector.Lifestyle.Singleton);
            container.Register<ITwitchHttpClientOptions>(() => OptionFactory.Create<TwitchHttpClientOptions>(twitchHttpClientOptionsJson), SimpleInjector.Lifestyle.Singleton);

            container.Register<HttpClient>(() => new HttpClient(), SimpleInjector.Lifestyle.Singleton);

            container.Register(typeof(ITwitchQueryHandler<,>), AppDomain.CurrentDomain.GetAssemblies());

            
            container.Verify();

            this.getTwitchTopVideosQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchTopVideosQuery, TwitchTopVideos>>();
            this.getTwitchLiveStreamsQueryHandler = container.GetInstance<ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams>>();

           

        }

        private async void liveStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var queryLiveStreams = container.GetInstance<GetTwitchLiveStreamsQuery>();

            queryLiveStreams.Limit = 18;

            LiveStreams livestreams = await getTwitchLiveStreamsQueryHandler.HandleAsync(queryLiveStreams);

            textBox1.Text = JsonConvert.SerializeObject(livestreams);

        }
    }
}
