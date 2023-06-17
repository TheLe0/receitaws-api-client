using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class AccountHistoric
    {
        [JsonPropertyName("calls")]
        public IEnumerable<HistoricApiCall> ApiCalls { get; set; }
    }
}
