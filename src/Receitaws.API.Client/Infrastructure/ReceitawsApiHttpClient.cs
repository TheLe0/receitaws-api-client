using System.Threading.Tasks;
using Receitaws.API.Client.Configuration;
using RestSharp;

namespace Receitaws.API.Client.Infrastructure
{
    public class ReceitawsApiHttpClient : IReceitawsApiHttpClient
    {
        private readonly RestClient _client;
        private readonly ReceitawsApiClientConfiguration _configuration;

        public ReceitawsApiHttpClient(ReceitawsApiClientConfiguration configuration)
        {
            _configuration = configuration;
            _client = new RestClient(GetConfigurations());
        }

        public ReceitawsApiHttpClient()
        {
            _configuration = new ReceitawsApiClientConfiguration();
            _client = new RestClient(GetConfigurations());
        }

        public ReceitawsApiHttpClient(string baseUrl)
        {
            _configuration = new ReceitawsApiClientConfiguration(baseUrl);
            _client = new RestClient(GetConfigurations());
        }

        public string GetBaseUrl()
        {
            return _configuration.BaseUrl;
        }

        public Task<T> GetAsync<T>(RestRequest request)
        {
            return _client.GetAsync<T>(request);
        }

        private RestClientOptions GetConfigurations()
        {
            return new RestClientOptions(_configuration.BaseUrl)
            {
                ThrowOnAnyError = _configuration.ThrowOnAnyError,
                MaxTimeout = _configuration.MaxTimeout
            };
        }
    }
}
