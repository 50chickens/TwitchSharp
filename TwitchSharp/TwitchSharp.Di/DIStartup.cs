using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;
using TwitchSharp.Implementations;

namespace TwitchSharp.Di
{
    public class DIStartup
    {
        public void CreateContainer(SimpleInjector.Container container, string queryOptionsJson, string twitchHttpClientOptionsJson)
        {

            container.Register<ITwitchClient, TwitchClient>();
            container.Register<ITwitchFileProcessor, TwitchFileProcessor>();
            container.Register<ITwitchHttpClient, TwitchHttpClient>(SimpleInjector.Lifestyle.Singleton);

            container.Register<ITwitchQueryOptions>(() => OptionFactory.Create<TwitchQueryOptions>(queryOptionsJson), SimpleInjector.Lifestyle.Singleton);
            container.Register<ITwitchHttpClientOptions>(() => OptionFactory.Create<TwitchHttpClientOptions>(twitchHttpClientOptionsJson), SimpleInjector.Lifestyle.Singleton);

            container.Register<HttpClient>(() => new HttpClient(), SimpleInjector.Lifestyle.Singleton);

            container.Register(typeof(ITwitchQueryHandler<,>), AppDomain.CurrentDomain.GetAssemblies());


            


        }
    }
}
