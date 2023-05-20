using System.Threading.Tasks;
using RestSharp;

namespace Receitaws.API.Client.Infrastructure
{
    public interface IReceitawsApiHttpClient
    {
        Task<T> GetAsync<T>(RestRequest request);
        string GetBaseUrl();
    }
}
