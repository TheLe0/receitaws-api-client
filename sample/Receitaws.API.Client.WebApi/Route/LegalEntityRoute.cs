namespace Receitaws.API.Client.WebApi.Route
{
    public static class LegalEntityRoute
    {
        public static WebApplication? AddLegalEntityEndpoints(this WebApplication? app)
        {
            app.AddFindByCnpjEndpoint();
            app.AddFindByCnpjPrecisionEndpoint();

            return app;
        }

        private static WebApplication? AddFindByCnpjEndpoint(this WebApplication? app)
        {
            if (app == null) return app;

            app.MapGet("/legal-entity/{cnpj}", (IReceitaws client, string cnpj) =>
            {
                return client.LegalEntity.FindByCnpj(cnpj);
            })
            .WithName("FindByCnpj")
            .WithOpenApi();

            return app;
        }

        private static WebApplication? AddFindByCnpjPrecisionEndpoint(this WebApplication? app)
        {
            if (app == null) return app;

            app.MapGet("/legal-entity/{cnpj}/{days}", (IReceitaws client, string cnpj, int days) =>
            {
                return client.LegalEntity.FindByCnpj(cnpj, days);
            })
            .WithName("FindByCnpjPrecisio")
            .WithOpenApi();

            return app;
        }
    }
}
