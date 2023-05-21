using System.Threading.Tasks;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Implementation;

public interface ILegalEntity
{
    Task<Company> FindByCnpj(string cnpj);
    Task<Company> FindByCnpj(string cnpj, int days);
}