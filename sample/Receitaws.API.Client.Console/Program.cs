var token = "";
var cnpj = "";

var client = new Receitaws.API.Client.Receitaws(token);

var company = await client.LegalEntity.FindByCnpj(cnpj)
    .ConfigureAwait(false);

company = await client.LegalEntity.FindByCnpj(cnpj, 15)
    .ConfigureAwait(false);

var accountProfile = await client.Account.GetAccountProfile()
    .ConfigureAwait(false);

var accountHistoricReport = await client.Account.GetAccountHistoricReport()
    .ConfigureAwait(false);