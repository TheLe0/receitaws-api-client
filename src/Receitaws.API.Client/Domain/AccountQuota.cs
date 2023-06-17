using System;
using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class AccountQuota
    {
        [JsonPropertyName("from_database")]
        public int DatabaseCreditQuantity { get; set; }
        [JsonPropertyName("from_external")]
        public int ExternalCreditQuantity { get; set; }

        [JsonPropertyName("next_renewal_date")]
        public DateTime? NextRenewalAt { get; set; }
    }
}
