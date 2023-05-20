namespace Receitaws.API.Client.Configuration
{
    public sealed class ReceitawsApiClientConfiguration : ApiConfiguration
    {
        public string Token { set; get; }
    
        public ReceitawsApiClientConfiguration(string token)
        {
            Token = token;

            SetupApiDefaultConfigs();
        }

        public ReceitawsApiClientConfiguration()
        {
            Token = null;
            SetupApiDefaultConfigs();
        }
    }
}
