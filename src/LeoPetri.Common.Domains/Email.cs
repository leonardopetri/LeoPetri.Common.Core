using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Domains
{
    public class Email
    {
        public string Address { get; private set; }
        public readonly string LocalPart;
        public readonly string Domain;

        public Email(string address)
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
