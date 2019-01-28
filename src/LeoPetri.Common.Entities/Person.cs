using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Entities
{
    public abstract class Person : BaseEntity<Guid>
    {
        private string _countryId;
        private string _name;

        public string Name { get { return _name; } set { _name = value.ToUpperFirstLetterName(); } }
        public string CountryId { get { return _countryId; } set { _countryId = value.NoSpecialChar(); } }
        public PersonType Type { get; private set; }

        public Person(Guid id, PersonType type) : base(id) => this.Type = type;

        public Person(Guid id, string name, PersonType type) : base(id)
        {
            this.Name = name;
            this.Type = type;
        }

        public Person(Guid id, string name, string countryId, PersonType type) : base(id)
        {
            this.Name = name;
            this.CountryId = countryId;
            this.Type = type;
        }

        public Person(PersonType type) : base(Guid.NewGuid()) => this.Type = type;

        public Person(string name, PersonType type) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.Type = type;
        }

        public Person(string name, string countryId, PersonType type) : base(Guid.NewGuid())
        {
            this.Name = name;
            this.CountryId = countryId;
            this.Type = type;
        }

        public override string ToString() => this.Name;
    }
}
