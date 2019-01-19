using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Domains
{
    public class NaturalPerson : Person
    {
        public NaturalPerson() : base(PersonType.NaturalPerson) { }

        public NaturalPerson(string name) : base(name, PersonType.NaturalPerson) { }

        public NaturalPerson(string name, string countryId) : base(name, countryId, PersonType.NaturalPerson)
        {
            if (!CountryIdFunctions.IsCpfValid(this.CountryId))
            {
                throw new FormatException("Not a valid CPF.");
            }
        }
    }
}
