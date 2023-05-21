using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain;

public class Contact
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("telefone")]
    public string Phone { get; set; }
}