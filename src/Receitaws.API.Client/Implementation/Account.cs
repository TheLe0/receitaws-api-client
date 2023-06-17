using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Domain;
using Receitaws.API.Client.Infrastructure;
using Receitaws.API.Client.Resources;
using System.Threading.Tasks;

namespace Receitaws.API.Client.Implementation;

public class Account : BaseApiClient, IAccount
{
    public Account() : base(Routes.Account) { }
    public Account(string token) : base(token, Routes.Account) { }
    public Account(ReceitawsApiClientConfiguration configuration) : base(configuration, Routes.Account) { }
    public Account(IReceitawsApiHttpClient restApiClient) : base(restApiClient, Routes.Account) { }

    public async Task<AccountProfile> GetAccountProfile()
    {
        ValidateAuthentication();

        Url.AppendPathSegment(Routes.Quota);

        return await GetAsync<AccountProfile>();
    }

    public async Task<AccountHistoric> GetAccountHistoricReport()
    {
        ValidateAuthentication();

        Url.AppendPathSegment(Routes.Calls);
        Url.AppendPathSegment(Routes.Report);

        return await GetAsync<AccountHistoric>();
    }
}