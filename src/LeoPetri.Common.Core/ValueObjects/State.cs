using LeoPetri.Common.Extensions;

namespace LeoPetri.Common.Core.ValueObjects
{
    public struct State
    {
        private string _name;
        private string _abbreviation;

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
