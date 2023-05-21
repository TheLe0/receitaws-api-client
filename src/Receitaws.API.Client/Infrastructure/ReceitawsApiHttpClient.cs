using System.Threading.Tasks;
using Receitaws.API.Client.Configuration;
using RestSharp;
using RestSharp.Authenticators;

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

        public ReceitawsApiHttpClient(string token)
        {
            _configuration = new ReceitawsApiClientConfiguration(token);
            _client = new RestClient(GetConfigurations());
        }

        public string GetBaseUrl()
        {
            return _configuration.BaseUrl;
        }

        public bool TokenIsNotNull()
        {
            return _configuration.Token != null;
        }

        public Task<T> GetAsync<T>(RestRequest request)
        {
            return _client.GetAsync<T>(request);
        }

        private RestClientOptions GetConfigurations()
        {
            var clientOptions =  new RestClientOptions(_configuration.BaseUrl)
            {
                ThrowOnAnyError = _configuration.ThrowOnAnyError,
                MaxTimeout = _configuration.MaxTimeout
                
            };

            if (!string.IsNullOrEmpty(_configuration.Token))
            {
                clientOptions.Authenticator = new JwtAuthenticator(_configuration.Token);
            }

            return clientOptions;
        }
    }
}
