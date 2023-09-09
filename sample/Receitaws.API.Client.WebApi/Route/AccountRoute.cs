namespace Receitaws.API.Client.WebApi.Route
{
    public static class AccountRoute
    {
        public static WebApplication? AddAccountEndpoints(this WebApplication? app)
        {
            app.AddAccountProfileEndpoint();
            app.AddHistoricReportEndpoint();

            return app;
        }

        private static WebApplication? AddAccountProfileEndpoint(this WebApplication? app)
        {
            if (app == null) return app;

            app.MapGet("/account/profile", (IReceitaws client) =>
            {
                return client.Account.GetAccountProfile();
            })
            .WithName("AccountProfile")
            .WithOpenApi();

            return app;
        }

        private static WebApplication? AddHistoricReportEndpoint(this WebApplication? app)
        {
            if (app == null) return app;

            app.MapGet("/account/historic-report", (IReceitaws client) =>
            {
                return client.Account.GetAccountHistoricReport();
            })
            .WithName("AccountHistoricReport")
            .WithOpenApi();

            return app;
        }
    }
}