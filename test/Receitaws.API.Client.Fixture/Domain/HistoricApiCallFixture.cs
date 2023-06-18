using Bogus;
using Bogus.Extensions.Brazil;
using Receitaws.API.Client.Domain;
using Receitaws.API.Client.Fixture.Core;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class HistoricApiCallFixture
    {
        public static IEnumerable<HistoricApiCall> AutoGenerate(int records = 1)
        {
            return new Faker<HistoricApiCall>()
                .RuleFor(u => u.CalledAt, (f) => f.Date.Past(1))
                .RuleFor(u => u.Token, _ => TextGeneratorFixture.AutoGenerate(65).ToString())
                .RuleFor(u => u.Cnpj, (f) => f.Company.Cnpj())
                .RuleFor(u => u.DayPrecision, (f) => f.Random.Int())
                .RuleFor(u => u.IsInvalid, (f) => f.Random.Bool())
                .RuleFor(u => u.IsFromDatabase, (f) => f.Random.Bool())
                .RuleFor(u => u.IsFromExternal, (f) => f.Random.Bool())
                .Generate(records);
        }
    }
}
