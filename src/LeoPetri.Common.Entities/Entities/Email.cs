using System;

namespace LeoPetri.Common.Core.Entities
{
    public class Email : Entity<Guid>
    {
        public string Address { get; private set; }
        public readonly string LocalPart;
        public readonly string Domain;

        public Email(Guid id, string address) : base(id)
        {
            var atIndex = address.IndexOf("@");
            this.Address = address;
            LocalPart = address.Substring(0, address.IndexOf("@"));
            Domain = address.Substring(address.IndexOf("@") + 1);
        }

        public Email(string address) : base(Guid.NewGuid())
        {
            var atIndex = address.IndexOf("@");
            this.Address = address;
            LocalPart = address.Substring(0, address.IndexOf("@"));
            Domain = address.Substring(address.IndexOf("@") + 1);
        }
    }
}
