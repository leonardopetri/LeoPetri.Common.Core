using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Entities
{
    public class LegalEntity : Person
    {
        public LegalEntity(Guid id) : base(id, PersonType.LegalEntity) { }

        public LegalEntity(Guid id, string name) : base(id, name, PersonType.NaturalPerson) { }

        public LegalEntity(Guid id, string name, string countryId) : base(id, name, countryId, PersonType.LegalEntity)
        {
            if (!CountryIdFunctions.IsCnpjValid(this.CountryId))
            {
                throw new FormatException("Not a valid CNPJ.");
            }
        }

        public LegalEntity() : base(PersonType.LegalEntity) { }

        public LegalEntity(string name) : base(name, PersonType.NaturalPerson) { }

        public LegalEntity(string name, string countryId) : base(name, countryId, PersonType.LegalEntity)
        {
            if (!CountryIdFunctions.IsCnpjValid(this.CountryId))
            {
                throw new FormatException("Not a valid CNPJ.");
            }
        }
    }
}
