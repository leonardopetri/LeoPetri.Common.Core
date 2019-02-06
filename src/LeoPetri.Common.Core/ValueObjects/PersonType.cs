using System.ComponentModel;

namespace LeoPetri.Common.Core.ValueObjects
{
    public enum PersonType
    {
        [DefaultValue("Pessoa Física")]
        NaturalPerson = 1,
        [DefaultValue("Pessoa Jusrídica")]
        LegalEntity = 2
    }
}
