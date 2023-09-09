namespace Receitaws.API.Client.WebApi.Common
{
    public static class ConfigurationExtension
    {
        public static T Parse<T>(this IConfiguration configuration, string key)
            where T : new()
        {
            var instance = new T();
            configuration.GetSection(key).Bind(instance);
            return instance;
        }
    }
}
