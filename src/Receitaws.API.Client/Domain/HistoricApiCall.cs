using System;
using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class HistoricApiCall
    {
        [JsonPropertyName("end")]
        public DateTime CalledAt { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }
        [JsonPropertyName("days")]
        public int DayPrecision { get; set; }
        [JsonPropertyName("invalid")]
        public bool IsInvalid { get; set; }
        [JsonPropertyName("from_database")]
        public bool IsFromDatabase { get; set; }
        [JsonPropertyName("from_external")]
        public bool IsFromExternal { get; set; }
    }
}
