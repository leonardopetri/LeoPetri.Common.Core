using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Entities
{
    public class Email : BaseEntity<Guid>
    {
        public string Address { get; private set; }
        public readonly string LocalPart;
        public readonly string Domain;

        public Email(Guid id, string address) : base(id)
        {
            if (!EmailFunctions.IsValid(address))
            {
                throw new FormatException("Not a valid email address.");
            }

            var atIndex = address.IndexOf("@");
            this.Address = address;
            this.LocalPart = address.Substring(0, address.IndexOf("@"));
            this.Domain = address.Substring(address.IndexOf("@") + 1);
        }

        public Email(string address) : base(Guid.NewGuid())
        {
            if (!EmailFunctions.IsValid(address))
            {
                throw new FormatException("Not a valid email address.");
            }

            var atIndex = address.IndexOf("@");
            this.Address = address;
            this.LocalPart = address.Substring(0, address.IndexOf("@"));
            this.Domain = address.Substring(address.IndexOf("@") + 1);
        }
    }
}
