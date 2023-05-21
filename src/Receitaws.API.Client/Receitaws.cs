using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Implementation;
using Receitaws.API.Client.Infrastructure;

namespace Receitaws.API.Client
{
    public class Receitaws : IReceitaws
    {
        public ILegalEntity LegalEntity { get; }
        public IAccount Account { get;  }
        
        public Receitaws(string token)
        {
            LegalEntity = new LegalEntity(token);
            Account = new Account(token);
        }

        public Receitaws(ReceitawsApiClientConfiguration configuration)
        {
            LegalEntity = new LegalEntity(configuration);
            Account = new Account(configuration);
        }

        public Receitaws(IReceitawsApiHttpClient restApiClient)
        {
            LegalEntity = new LegalEntity(restApiClient);
            Account = new Account(restApiClient);
        }

        public Receitaws()
        {
            LegalEntity = new LegalEntity();
            Account = new Account();
        }
    }
}
