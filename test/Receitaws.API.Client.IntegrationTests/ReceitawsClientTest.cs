using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Exceptions;

namespace Receitaws.API.Client.IntegrationTests
{
    public class ReceitawsClientTest
    {
        private readonly IReceitaws _client;

        public ReceitawsClientTest()
        {
            _client = new Receitaws(new ReceitawsApiClientConfiguration
            {
                MaxTimeout = 60000,
                ThrowOnAnyError = true
            });
        }

        [InlineData("92875780000131", "92.875.780/0001-31")]
        [InlineData("12455479000130", "12.455.479/0001-30")]
        [InlineData("09552812000114", "09.552.812/0001-14")]
        [Theory]
        public async void FindByCnpj_WithoutDayRange_Success(string cnpj, string formatedCnpj)
        {
            var company = await _client.LegalEntity.FindByCnpj(cnpj);

            Assert.NotNull(company);
            Assert.Equal(company.Cnpj, formatedCnpj);
        }

        [InlineData("92875780000131")]
        [InlineData("12455479000130")]
        [InlineData("09552812000114")]
        [Theory]
        public async void FindByCnpj_WithDayRange_Fail_Throws_UnauthenticatedNotAllowedException(string cnpj)
        {
            var client = new Receitaws();

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
           await client.LegalEntity.FindByCnpj(cnpj, 15));
        }

        [Fact]
        public async void GetAccountProfile_Fail_Throws_UnauthenticatedNotAllowedException()
        {
            var client = new Receitaws();

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
                await _client.Account.GetAccountProfile());
        }

        [Fact]
        public async void GetAccountHistoricReport_Fail_Throws_UnauthenticatedNotAllowedException()
        {
            var client = new Receitaws();

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
                await _client.Account.GetAccountHistoricReport());
        }
    }
}
