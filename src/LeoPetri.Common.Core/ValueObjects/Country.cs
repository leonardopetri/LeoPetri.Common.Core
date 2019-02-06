using LeoPetri.Common.Extensions;

namespace LeoPetri.Common.Core.ValueObjects
{
    public struct Country
    {
        private string _name;
        private string _abbreviation;

        public uint Id { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpperFirstLetterName(); }
        }

        public string Abbreviation
        {
            get { return _abbreviation; }
            set { _abbreviation = value.ToUpper(); }
        }
    }
}
