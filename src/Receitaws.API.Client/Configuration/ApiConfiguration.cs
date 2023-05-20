using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Configuration
{
    public abstract class ApiConfiguration : RestSharpConfiguration
    {
        public string BaseUrl { get; set; }
        
        protected void SetupApiDefaultConfigs()
        {
            BaseUrl = Routes.BaseApiPath;

            SetupRestSharpDefaultConfigs();
        }
    }
}
