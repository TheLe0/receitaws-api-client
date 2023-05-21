using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain;

public class RequestBilling
{
    [JsonPropertyName("free")]
    public bool IsFreeData { get; set; }
    
    [JsonPropertyName("database")]
    public bool DataIsFromCache { get; set; }
}