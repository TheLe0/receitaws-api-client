﻿using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.Infrastructure;
using Receitaws.API.Client.Resources;

namespace Receitaws.API.Client.Implementation;

public class Account : BaseApiClient, IAccount
{
    public Account() : base(Routes.Account) { }
    public Account(string token) : base(token, Routes.Account) { }
    public Account(ReceitawsApiClientConfiguration configuration) : base(configuration, Routes.Account) { }
    public Account(IReceitawsApiHttpClient restApiClient) : base(restApiClient, Routes.Account) { }
}