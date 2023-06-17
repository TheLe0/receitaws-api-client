using Receitaws.API.Client.Domain;
using System.Threading.Tasks;

namespace Receitaws.API.Client.Implementation;

public interface IAccount
{
    Task<AccountProfile> GetAccountProfile();
    Task<AccountHistoric> GetAccountHistoricReport();
}