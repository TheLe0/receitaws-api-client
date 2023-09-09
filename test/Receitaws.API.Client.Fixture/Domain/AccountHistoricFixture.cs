using Bogus;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class AccountHistoricFixture
    {
        public static AccountHistoric AutoGenerate(int records = 1)
        {
            return new Faker<AccountHistoric>()
                .RuleFor(u => u.ApiCalls, _ => HistoricApiCallFixture.AutoGenerate(records))
                .Generate();
        }
    }
}
