using SimpleInjector.Lifestyles;
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
            //container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.Register<ITwitchClient, TwitchClient>();
            //container.Register<ITwitchM3UFileProcessor, TwitchM3UFileProcessor>();
            container.Register<ITwitchFileProcessor, TwitchFileProcessor>();
            container.Register<ITwitchMediaFileProcessor, TwitchMediaFileProcessor>();

            container.Register<ITwitchDataClient, TwitchHttpClient>(SimpleInjector.Lifestyle.Singleton);
            container.Register<ITwitchDataDownloadClient, TwitchDataDownloadClient>(SimpleInjector.Lifestyle.Singleton);
            
            //container.Register<ITwitchDataClient, TwitchFileClient>(SimpleInjector.Lifestyle.Singleton);

            container.Register<ITwitchQueryOptions>(() => OptionFactory.Create<TwitchQueryOptions>(queryOptionsJson), SimpleInjector.Lifestyle.Singleton);
            container.Register<ITwitchHttpClientOptions>(() => OptionFactory.Create<TwitchHttpClientOptions>(twitchHttpClientOptionsJson), SimpleInjector.Lifestyle.Singleton);

            container.Register<HttpClient>(() => new HttpClient(), SimpleInjector.Lifestyle.Singleton);

            container.Register(typeof(ITwitchQueryHandler<,>), AppDomain.CurrentDomain.GetAssemblies());

            container.Register(typeof(ICommandHandler<>), AppDomain.CurrentDomain.GetAssemblies());



        }
    }
}
