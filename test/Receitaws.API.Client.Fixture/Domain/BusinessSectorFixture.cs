using Bogus;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class BusinessSectorFixture
    {
        public static IEnumerable<BusinessSector> AutoGenerate(int records = 1)
        {
            return new Faker<BusinessSector>()
                .RuleFor(u => u.Code, (f) => f.Company.CompanySuffix())
                .RuleFor(u => u.Definition, (f) => f.Company.CompanyName())
                .Generate(records);
        }
    }
}
