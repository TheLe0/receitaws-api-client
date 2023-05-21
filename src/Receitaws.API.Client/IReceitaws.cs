using Receitaws.API.Client.Implementation;

namespace Receitaws.API.Client
{
    public interface IReceitaws
    {
        IAccount Account { get; }
        ILegalEntity LegalEntity { get;  }
    }
}
