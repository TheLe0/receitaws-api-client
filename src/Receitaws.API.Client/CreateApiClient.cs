using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Implementation;
using Receitaws.API.Client.Infrastructure;

namespace Receitaws.API.Client
{
    public class CreateApiClient : ICreateApiClient
    {

        public CreateApiClient(string baseUrl)
        {
        }

        public CreateApiClient(ReceitawsApiClientConfiguration configuration)
        {
        }

        public CreateApiClient(IReceitawsApiHttpClient restApiClient)
        {
        }

        public CreateApiClient()
        {
        }
    }
}
