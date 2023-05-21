using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain;

public class BusinessSector
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
    [JsonPropertyName("text")]
    public string Definition { get; set; }
}