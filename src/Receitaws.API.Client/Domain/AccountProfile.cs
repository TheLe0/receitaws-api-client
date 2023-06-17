using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class AccountProfile
    {
        [JsonPropertyName("quota")]
        public AccountQuota Quota { get; set; }
    }
}
