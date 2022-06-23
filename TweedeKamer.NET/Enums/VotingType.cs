using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum VotingType
{
    [EnumMember(Value = "Hoofdelijk")]
    Hoofdelijk,
    [EnumMember(Value = "Met Handopsteken")]
    MetHandopsteken,
    [EnumMember(Value = "Zonder Stemming")]
    ZonderStemming
}