using Bogus;
using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Domain;

namespace Receitaws.API.Client.Fixture.Domain
{
    public static class RequestBillingFixture
    {
        public static RequestBilling AutoGenerate()
        {
            return new Faker<RequestBilling>()
                .RuleFor(u => u.IsFreeData, (f) => f.Random.Bool())
                .RuleFor(u => u.DataIsFromCache, (f) => f.Random.Bool())
                .Generate();
        }
    }
}
