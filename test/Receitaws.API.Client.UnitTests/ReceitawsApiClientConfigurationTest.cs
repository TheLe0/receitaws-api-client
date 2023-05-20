using Receitaws.API.Client.Configuration;

namespace Receitaws.API.Client.UnitTests
{
    public class ReceitawsApiClientConfigurationTest
    {
        [Fact]
        public void ReceitawsApiClientConfiguration_DefaultValues()
        {
            var configuration = new ReceitawsApiClientConfiguration();

            Assert.NotEqual(string.Empty, configuration.BaseUrl);
            Assert.NotEqual(0, configuration.MaxTimeout);
            Assert.Null(configuration.Token);
            Assert.True(configuration.ThrowOnAnyError);
        }
        
        [Fact]
        public void ReceitawsApiClientConfiguration_WithToken()
        {
            var token = Guid.NewGuid().ToString();
            var configuration = new ReceitawsApiClientConfiguration(token);

            Assert.Equal(token, configuration.Token);
            Assert.Equal(10000, configuration.MaxTimeout);
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/", 0, true)]
        [InlineData("https://localhost:3000/", 1000, false)]
        [Theory]
        public void ReceitawsApiClientConfiguration_WithCustom(string baseUrl, int maxTimeOut, bool throwOnErrors)
        {
            var configuration = new ReceitawsApiClientConfiguration
            {
                Token = Guid.NewGuid().ToString(),
                BaseUrl = baseUrl,
                MaxTimeout = maxTimeOut,
                ThrowOnAnyError = throwOnErrors
            };

            Assert.Equal(baseUrl, configuration.BaseUrl);
            Assert.Equal(maxTimeOut, configuration.MaxTimeout);
            Assert.Equal(throwOnErrors, configuration.ThrowOnAnyError);
        }
    }
}
