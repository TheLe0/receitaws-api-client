using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain;

public class Address
{
    [JsonPropertyName("logradouro")]
    public string Street { get; set; }

    [JsonPropertyName("numero")]
    public string Number { get; set; }

    [JsonPropertyName("complemento")]
    public string Complement { get; set; }

    [JsonPropertyName("municipio")]
    public string City { get; set; }

    [JsonPropertyName("bairro")]
    public string District { get; set; }
    
    [JsonPropertyName("uf")] 
    public string State { get; set; }

    [JsonPropertyName("cep")] 
    public string ZipCode { get; set; }
}