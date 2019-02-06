using System;

namespace LeoPetri.Common.Core.Entities
{
    public class Email : Entity<Guid>
    {
        private string _address;

        public string Address { get { return _address; } private set { _address = value.ToLower(); } }
        public string LocalPart { get; private set; }
        public string Domain { get; private set; }

        public Email(Guid id, string address) : base(id)
        {
            this.Address = address;

            this.SetLocalPartAndDomain(this.Address);
        }

        public Email(string address) : base(Guid.NewGuid())
        {
            this.Address = address;

            this.SetLocalPartAndDomain(this.Address);
        }

        private void SetLocalPartAndDomain(string address)
        {
            var atIndex = address.IndexOf("@");

            if (atIndex > 0)
            {
                LocalPart = address.Substring(0, address.IndexOf("@"));
                Domain = address.Substring(address.IndexOf("@") + 1);
            }
        }
    }
}
