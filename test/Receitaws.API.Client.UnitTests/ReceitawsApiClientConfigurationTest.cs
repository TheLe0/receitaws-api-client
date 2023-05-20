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
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/")]
        [InlineData("https://localhost:3000/")]
        [Theory]
        public void ReceitawsApiClientConfiguration_WithCustomBaseUrl(string baseUrl)
        {
            var configuration = new ReceitawsApiClientConfiguration(baseUrl);

            Assert.Equal(baseUrl, configuration.BaseUrl);
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
