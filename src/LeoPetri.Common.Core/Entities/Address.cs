using LeoPetri.Common.Core.ValueObjects;
using LeoPetri.Common.Extensions;
using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Core.Entities
{
    public class Address : Entity<Guid>
    {
        private string _street;
        private string _complement;
        private string _district;
        private string _city;
        private string _zipCode;

        public Address() : base(Guid.NewGuid()) { }

        public Address(Guid id) : base(id) { }

        public string Street
        {
            get { return _street; }
            set { _street = value.ToUpperFirstLetterName(); }
        }

        public int? Number { get; set; }

        public string Complement
        {
            get { return _complement; }
            set { _complement = value.ToUpperFirstLetterName(); }
        }

        public string District
        {
            get { return _district; }
            set { _district = value.ToUpperFirstLetterName(); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value.ToUpperFirstLetterName(); }
        }

        public State? State { get; set; }

        public Country? Country { get; set; } = new Country() { Id = 76, Name = "Brasil", Abbreviation = "BR" };

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value.ToUpperFirstLetterName(); }
        }

        public override string ToString()
        {
            return AddressFunctions.ToBrazilianFormat(this.Street, this.Number, this.Complement, this.District, this.City, (string.IsNullOrWhiteSpace(this.State?.Abbreviation) ? this.State?.Name : this.State?.Abbreviation), this.ZipCode);
        }
    }
}
