using Receitaws.API.Client.Domain;
using Receitaws.API.Client.Exceptions;
using Receitaws.API.Client.Fixture.Domain;
using Receitaws.API.Client.Infrastructure;
using RestSharp;

namespace Receitaws.API.Client.UnitTests
{
    public class ReceitawsTest
    {
        private readonly IReceitaws _client;
        private readonly Mock<IReceitawsApiHttpClient> _httpClientMock;

        public ReceitawsTest()
        {
            _httpClientMock = new Mock<IReceitawsApiHttpClient>();
            _client = new Receitaws(_httpClientMock.Object);
        }

        [Fact]
        public async void FindByCnpj_WithoutDayRange_Success()
        {
            var companyFixture = CompanyFixture.AutoGenerate();

            _httpClientMock.Setup(_ =>
                _.GetAsync<Company>(It.IsAny<RestRequest>()))
                .ReturnsAsync(companyFixture);

            var company = await _client.LegalEntity.FindByCnpj(companyFixture.Cnpj);

            Assert.NotNull(company);
            Assert.Equal(company.Cnpj, companyFixture.Cnpj);
        }

        [Fact]
        public async void FindByCnpj_WithDayRange_Success()
        {
            var companyFixture = CompanyFixture.AutoGenerate();

            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(true);

            _httpClientMock.Setup(_ =>
                _.GetAsync<Company>(It.IsAny<RestRequest>()))
                .ReturnsAsync(companyFixture);

            var company = await _client.LegalEntity.FindByCnpj(companyFixture.Cnpj, 15);

            Assert.NotNull(company);
            Assert.Equal(company.Cnpj, companyFixture.Cnpj);
        }

        [Fact]
        public async void FindByCnpj_WithDayRange_Fail_Throws_UnauthenticatedNotAllowedException()
        {
            var companyFixture = CompanyFixture.AutoGenerate();

            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(false);

            _httpClientMock.Setup(_ =>
                _.GetAsync<Company>(It.IsAny<RestRequest>()))
                .ReturnsAsync(companyFixture);

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
             await _client.LegalEntity.FindByCnpj(companyFixture.Cnpj, 15));
        }

        [Fact]
        public async void GetAccountProfile_Success()
        {
            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(true);

            _httpClientMock.Setup(_ =>
                _.GetAsync<AccountProfile>(It.IsAny<RestRequest>()))
                .ReturnsAsync(AccountProfileFixture.AutoGenerate());

            var profile = await _client.Account.GetAccountProfile();

            Assert.NotNull(profile);
            Assert.NotNull(profile.Quota);
        }

        [Fact]
        public async void GetAccountProfile_Fail_Throws_UnauthenticatedNotAllowedException()
        {
            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(false);

            _httpClientMock.Setup(_ =>
                _.GetAsync<AccountProfile>(It.IsAny<RestRequest>()))
                .ReturnsAsync(AccountProfileFixture.AutoGenerate());

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
                await _client.Account.GetAccountProfile());
        }

        [Fact]
        public async void GetAccountHistoricReport_Success()
        {
            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(true);

            _httpClientMock.Setup(_ =>
                _.GetAsync<AccountHistoric>(It.IsAny<RestRequest>()))
                .ReturnsAsync(AccountHistoricFixture.AutoGenerate());

            var historicReport = await _client.Account.GetAccountHistoricReport();

            Assert.NotNull(historicReport);
            Assert.NotEmpty(historicReport.ApiCalls);
        }

        [Fact]
        public async void GetAccountHistoricReport_Fail_Throws_UnauthenticatedNotAllowedException()
        {
            _httpClientMock.Setup(_ =>
               _.TokenIsNotNull())
               .Returns(false);

            _httpClientMock.Setup(_ =>
                _.GetAsync<AccountHistoric>(It.IsAny<RestRequest>()))
                .ReturnsAsync(AccountHistoricFixture.AutoGenerate());

            await Assert.ThrowsAsync<UnauthenticatedNotAllowedException>(async () =>
                await _client.Account.GetAccountHistoricReport());
        }
    }
}
