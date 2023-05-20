using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Configuration
{
    public abstract class RestSharpConfiguration : ApiConfiguration
    {
        public bool ThrowOnAnyError { get; set; }
        public int MaxTimeout { get; set; }

        protected void SetupDefaultConfigs()
        {
            MaxTimeout = int.Parse(Configurations.MaxTimeout);
            ThrowOnAnyError = bool.Parse(Configurations.ThrowOnAnyError);
        }
    }
}
