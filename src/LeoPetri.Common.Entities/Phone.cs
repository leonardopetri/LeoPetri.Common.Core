using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Entities
{
    public class Phone : BaseEntity<Guid> 
    {
        public ushort Ddi { get; private set; } = 55;
        public ushort Ddd { get; private set; }
        public ulong Number { get; private set; }

        public Phone(Guid id, ulong number) : this(id, number.ToString()) { }

        public Phone(Guid id, string number) : base(id)
        {
            var numberStr = number.NumbersOnly();

            this.Ddd = ushort.Parse(numberStr.Substring(0, 2));
            this.Number = ulong.Parse(numberStr.Substring(2));
        }

        public Phone(Guid id, string ddi, string ddd, string number) : base(id)
        {
            this.Ddi = ushort.Parse(ddi.NumbersOnly());
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone(Guid id, string ddd, string number) : base(id)
        {
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone(Guid id, ushort ddd, ulong number) : base(id)
        {
            this.Ddd = ddd;
            this.Number = number;
        }

        public Phone(Guid id, ushort ddi, ushort ddd, ulong number) : base(id)
        {
            this.Ddi = ddi;
            this.Ddd = ddd;
            this.Number = number;
        }

        public Phone(ulong number) : this(number.ToString()) { }

        public Phone(string number) : base(Guid.NewGuid())
        {
            var numberStr = number.NumbersOnly();

            this.Ddd = ushort.Parse(numberStr.Substring(0, 2));
            this.Number = ulong.Parse(numberStr.Substring(2));
        }

        public Phone(string ddi, string ddd, string number) : base(Guid.NewGuid())
        {
            this.Ddi = ushort.Parse(ddi.NumbersOnly());
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone(string ddd, string number) : base(Guid.NewGuid())
        {
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone (ushort ddd, ulong number) : base(Guid.NewGuid())
        {
            this.Ddd = ddd;
            this.Number = number;
        }

        public Phone(ushort ddi, ushort ddd, ulong number) : base(Guid.NewGuid())
        {
            this.Ddi = ddi;
            this.Ddd = ddd;
            this.Number = number;
        }

        public override string ToString()
        {
            if (this.Number.ToString().Length > 8)
            {
                return this.Ddd.ToString("00") + this.Number.ToString("000000000");
            }

            return this.Ddd.ToString("00") + this.Number.ToString("00000000");
        }

        public string ToStringWithDdi()
        {
            if (this.Number.ToString().Length > 8)
            {
                return this.Ddi.ToString("##0") + this.Ddd.ToString("00") + this.Number.ToString("000000000");
            }

            return this.Ddi.ToString("##0") + this.Ddd.ToString("00") + this.Number.ToString("00000000");
        }
    }
}
