using Bogus;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class ShareholderStructureFixture
    {
        public static IEnumerable<ShareholderStructure> AutoGenerate(int records = 1)
        {
            return new Faker<ShareholderStructure>()
                .RuleFor(u => u.Name, (f) => f.Person.FullName)
                .RuleFor(u => u.ShareholderQualification, (f) => f.Company.CompanyName())
                .RuleFor(u => u.ShareholderQualification, (f) => f.Address.CountryCode())
                .RuleFor(u => u.AuthorizedRepresentativeName, (f) => f.Person.FullName)
                .RuleFor(u => u.AuthorizedRepresentativeQualification, (f) => f.Company.CompanyName())
                .Generate(records);
        }
    }
}
