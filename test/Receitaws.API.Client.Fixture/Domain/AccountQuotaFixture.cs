using Bogus;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class AccountQuotaFixture
    {
        public static AccountQuota AutoGenerate()
        {
            return new Faker<AccountQuota>()
                .RuleFor(u => u.DatabaseCreditQuantity, (f) => f.Random.Int(0, 1000))
                .RuleFor(u => u.ExternalCreditQuantity, (f) => f.Random.Int(0, 1000))
                .RuleFor(u => u.NextRenewalAt, (f) => f.Date.Future(1))
                .Generate();
        }
    }
}
