using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Receitaws.API.Client.Converters;

namespace Receitaws.API.Client.Domain;

public class Company
{
    [JsonPropertyName("ultima_atualizacao")]
    public DateTime ModifiedAt { set; get; }
    
    [JsonPropertyName("cnpj")]
    public string Cnpj { set; get; }
    
    [JsonPropertyName("nome")]
    public string Name { get; set; }
    
    [JsonPropertyName("fantasia")]
    public string TradeName { get; set; }
    
    [JsonPropertyName("porte")]
    public string MarketCapitalization { get; set; }
    
    [JsonPropertyName("natureza_juridica")]
    public string LegalForm { get; set; }
    
    [JsonConverter(typeof(CustomDateTimeConverter))]
    [JsonPropertyName("abertura")]
    public DateTime FoundingDate { get; set; }
    
    [JsonPropertyName("atividade_principal")]
    public IEnumerable<BusinessSector> PrimarySectors { get; set; }
    
    [JsonPropertyName("atividades_secundarias")]
    public IEnumerable<BusinessSector> SecondarySectors { get; set; }
    
    [JsonPropertyName("efr")]
    public string ResponsibleFederativeEntity { get; set; }
    
    [JsonPropertyName("tipo")]
    public string BranchType { set; get; }
    
    [JsonPropertyName("email")]
    public string Email { get; set; }
    
    [JsonPropertyName("telefone")]
    public string Phone { get; set; }    
    
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

    [JsonPropertyName("capital_social")]
    public decimal EquityCapital { get; set; }

    [JsonPropertyName("situacao")]
    public string Situation { get; set; }

    [JsonPropertyName("motivo_situacao")]
    public string SituationReason { get; set; }

    [JsonConverter(typeof(CustomDateTimeConverter))]
    [JsonPropertyName("data_situacao")]
    public DateTime SituationDate { get; set; }

    [JsonPropertyName("situacao_especial")]
    public string SpecialSituation { get; set; }

    [JsonConverter(typeof(CustomDateTimeConverter))]
    [JsonPropertyName("data_situacao_especial")]
    public DateTime SpecialSituationDate { get; set; }

    [JsonPropertyName("billing")]
    public RequestBilling RequestBilling { get; set; }
    
    [JsonPropertyName("qsa")]
    public IEnumerable<ShareholderStructure> ShareholderStructure { get; set; }

}