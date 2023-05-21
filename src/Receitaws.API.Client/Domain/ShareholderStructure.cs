using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Domain
{
    public class ShareholderStructure
    {
        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("qual")]
        public string ShareholderQualification { get; set; }

        [JsonPropertyName("pais_origem")]
        public string Country { get; set; }

        [JsonPropertyName("nome_rep_legal")]
        public string AuthorizedRepresentativeName { get; set; }

        [JsonPropertyName("qual_rep_legal")]
        public string AuthorizedRepresentativeQualification { get; set; }

    }
}
