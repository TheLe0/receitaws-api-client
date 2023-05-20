using Receitaws.API.Client.Configuration;
using Flurl;
using RestSharp;
using System.Threading.Tasks;
using Receitaws.API.Client.Infrastructure;

namespace Receitaws.API.Client.Implementation
{
    public abstract class BaseApiClient
    {
        private readonly IReceitawsApiHttpClient _httpClient;
        protected readonly Url Endpoint;

        protected BaseApiClient(string baseUrl)
        {
            _httpClient = new ReceitawsApiHttpClient(baseUrl);
            Endpoint = _httpClient.GetBaseUrl();
        }


        protected BaseApiClient(IReceitawsApiHttpClient restApiClient)
        {
            _httpClient = restApiClient;
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient()
        {
            _httpClient = new ReceitawsApiHttpClient();
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient(ReceitawsApiClientConfiguration configuration)
        {
            _httpClient = new ReceitawsApiHttpClient(configuration);
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected Task<T> GetAsync<T>()
        {
            var restRequest = new RestRequest(Endpoint.ToString());
            RefreshEndpoint();

            return _httpClient.GetAsync<T>(restRequest);
        }

        private void RefreshEndpoint()
        {
            Endpoint.Reset();
        }
    }
}
