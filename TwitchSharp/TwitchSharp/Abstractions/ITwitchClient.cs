using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchClient
    {
        Task<T> GetTwitchData<T>(string url);
        Task<string> GetTwitchDataAsString(string url);

    }
}