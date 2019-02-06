using LeoPetri.Common.Core.ValueObjects;
using System;

namespace LeoPetri.Common.Core.Entities
{
    public class NaturalPerson : Person
    {
        public NaturalPerson(Guid id) : base(id, PersonType.NaturalPerson) { }

        public NaturalPerson(Guid id, string name) : base(id, name, PersonType.NaturalPerson) { }

        public NaturalPerson(Guid id, string name, string countryId) : base(id, name, countryId, PersonType.NaturalPerson) { }

        public NaturalPerson() : base(PersonType.NaturalPerson) { }

        public NaturalPerson(string name) : base(name, PersonType.NaturalPerson) { }

        public NaturalPerson(string name, string countryId) : base(name, countryId, PersonType.NaturalPerson) { }
    }
}
