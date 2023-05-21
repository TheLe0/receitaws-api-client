using Receitaws.API.Client.Configuration;
using Flurl;
using RestSharp;
using System.Threading.Tasks;
using Receitaws.API.Client.Exceptions;
using Receitaws.API.Client.Infrastructure;
using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Implementation
{
    public abstract class BaseApiClient
    {
        private readonly IReceitawsApiHttpClient _httpClient;
        private readonly string _endpoint;
        protected readonly Url Url;
        
        protected BaseApiClient(string token, string endpoint)
        {
            _httpClient = new ReceitawsApiHttpClient(token);
            _endpoint = endpoint;
            Url = _httpClient.GetBaseUrl();
            RefreshEndpoint();
        }


        protected BaseApiClient(IReceitawsApiHttpClient restApiClient, string endpoint)
        {
            _httpClient = restApiClient;
            _endpoint = endpoint;
            Url = _httpClient.GetBaseUrl();
            RefreshEndpoint();
        }

        protected BaseApiClient(string endpoint)
        {
            _httpClient = new ReceitawsApiHttpClient();
            _endpoint = endpoint;
            Url = _httpClient.GetBaseUrl();
            RefreshEndpoint();
        }

        protected BaseApiClient(ReceitawsApiClientConfiguration configuration, string endpoint)
        {
            _httpClient = new ReceitawsApiHttpClient(configuration);
            _endpoint = endpoint;
            Url = _httpClient.GetBaseUrl();
            RefreshEndpoint();
        }

        protected Task<T> GetAsync<T>()
        {
            var restRequest = new RestRequest(Url.ToString());
            RefreshEndpoint();

            return _httpClient.GetAsync<T>(restRequest);
        }

        protected void ValidateAuthentication()
        {
            if (!_httpClient.TokenIsNotNull())
                throw new UnauthenticatedNotAllowedException("You must specify a token to access this method");
        }

        private void RefreshEndpoint()
        {
            Url.Reset();
            AddBaseUrlSegments();
        }

        private void AddBaseUrlSegments()
        {
            SetupApiVersion();
            SetupBaseEndpoint();
        }

        private void SetupApiVersion()
        {
            Url.AppendPathSegment(Routes.Version1);
        }

        private void SetupBaseEndpoint()
        {
            Url.AppendPathSegment(_endpoint);
        }
    }
}
