using Bogus;
using Receitaws.API.Client.Configuration;

namespace Receitaws.API.Client.Fixture.Configuration
{
    public static class ReceitawsApiClientConfigurationFixture
    {
        public static ReceitawsApiClientConfiguration AutoGenerate(bool withValidToken)
        {
            return new Faker<ReceitawsApiClientConfiguration>()
                .RuleFor(u => u.Token, (f) =>
                    withValidToken ?
                        f.Random.AlphaNumeric(65)
                        : string.Empty)
                .RuleFor(u => u.BaseUrl, (f) => f.Internet.Url())
                .RuleFor(u => u.ThrowOnAnyError, (f) => f.Random.Bool())
                .RuleFor(u => u.MaxTimeout, (f) => f.Random.Int(0, 1000))
                .Generate();
        }
    }
}
