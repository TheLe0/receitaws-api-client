using Bogus;
using Bogus.Extensions.Brazil;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class CompanyFixture
    {
        public static Company AutoGenerate()
        {
            return new Faker<Company>()
                .RuleFor(u => u.ModifiedAt, (f) => f.Date.Past(1))
                .RuleFor(u => u.Cnpj, (f) => f.Company.Cnpj())
                .RuleFor(u => u.Name, (f) => f.Company.CompanyName())
                .RuleFor(u => u.TradeName, (f) => f.Company.CompanySuffix())
                .RuleFor(u => u.MarketCapitalization, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.LegalForm, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.FoundingDate, (f) => f.Date.Past(1))
                .RuleFor(u => u.PrimarySectors, _ => BusinessSectorFixture.AutoGenerate())
                .RuleFor(u => u.SecondarySectors, _ => BusinessSectorFixture.AutoGenerate())
                .RuleFor(u => u.ResponsibleFederativeEntity, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.BranchType, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.Email, (f) => f.Internet.Email())
                .RuleFor(u => u.Phone, (f) => f.Phone.PhoneNumber())
                .RuleFor(u => u.Street, (f) => f.Address.StreetAddress())
                .RuleFor(u => u.Number, (f) => f.Address.BuildingNumber())
                .RuleFor(u => u.Complement, (f) => f.Address.CountryCode())
                .RuleFor(u => u.City, (f) => f.Address.City())
                .RuleFor(u => u.District, (f) => f.Address.StreetSuffix())
                .RuleFor(u => u.State, (f) => f.Address.State())
                .RuleFor(u => u.ZipCode, (f) => f.Address.ZipCode())
                .RuleFor(u => u.EquityCapital, (f) => f.Random.Decimal())
                .RuleFor(u => u.Situation, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.SituationReason, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.SituationDate, (f) => f.Date.Past(1))
                .RuleFor(u => u.SpecialSituation, (f) => f.Company.CatchPhrase())
                .RuleFor(u => u.SpecialSituationDate, (f) => f.Date.Past(1))
                .RuleFor(u => u.RequestBilling, _ => RequestBillingFixture.AutoGenerate())
                .RuleFor(u => u.ShareholderStructure, _ => ShareholderStructureFixture.AutoGenerate())
                .Generate();
        }
    }
}
