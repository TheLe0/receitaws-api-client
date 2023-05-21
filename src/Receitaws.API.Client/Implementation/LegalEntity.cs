using System.Threading.Tasks;
using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Domain;
using Receitaws.API.Client.Infrastructure;
using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Implementation;

public class LegalEntity : BaseApiClient, ILegalEntity
{
    public LegalEntity() : base(Routes.LegalEntity) { }
    public LegalEntity(string token) : base(token, Routes.LegalEntity) { }
    public LegalEntity(ReceitawsApiClientConfiguration configuration) : base(configuration, Routes.LegalEntity) { }
    public LegalEntity(IReceitawsApiHttpClient restApiClient) : base(restApiClient, Routes.LegalEntity) { }

    public async Task<Company> FindByCnpj(string cnpj)
    {
        Url.AppendPathSegment(cnpj);

        return await GetAsync<Company>();
    }

    public async Task<Company> FindByCnpj(string cnpj, int days)
    {
        ValidateAuthentication();

        Url.AppendPathSegment(cnpj);

        Url.AppendPathSegment(Routes.Days);
        Url.AppendPathSegment(days);

        return await GetAsync<Company>();
    }
}