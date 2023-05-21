using System.Runtime.Serialization;

namespace Receitaws.API.Client.Domain;

public enum BranchType
{
    [EnumMember(Value = "MATRIZ")]
    Headquarter,
    [EnumMember(Value = "FILIAL")]
    Branch
}