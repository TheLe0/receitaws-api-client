using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Configuration
{
    public class ReceitawsApiClientConfiguration : RestSharpConfiguration
    {
        public ReceitawsApiClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;

            SetupDefaultConfigs();
        }

        public ReceitawsApiClientConfiguration()
        {
            BaseUrl = Routes.BaseApiPath;

            SetupDefaultConfigs();
        }
    }
}
