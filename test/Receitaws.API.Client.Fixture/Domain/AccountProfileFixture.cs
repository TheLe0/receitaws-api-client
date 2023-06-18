using Bogus;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class AccountProfileFixture
    {
        public static AccountProfile AutoGenerate()
        {
            return new Faker<AccountProfile>()
                .RuleFor(u => u.Quota, _ => AccountQuotaFixture.AutoGenerate())
                .Generate();
        }
    }
}
