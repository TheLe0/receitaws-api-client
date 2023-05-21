// See https://aka.ms/new-console-template for more information

using Receitaws.API.Client;

var client = new Receitaws.API.Client.Receitaws();

var company = await client.LegalEntity.FindByCnpj("09720710000160")
    .ConfigureAwait(false);

Console.WriteLine("Hello, World!");
