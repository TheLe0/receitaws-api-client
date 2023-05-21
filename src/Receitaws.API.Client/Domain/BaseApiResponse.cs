using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class BaseApiResponse
    {
        [JsonPropertyName("status")]
        public string Status { set; get; }
    }
}
