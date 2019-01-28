using System;
using Xunit;

namespace LeoPetri.Common.Entities.UnitTest
{
    public class PhoneShould
    {
        [Theory]
        [InlineData(11234512342, "df620aa9-bfa5-4ea2-b042-20246bdf8b48")]
        [InlineData(1123452342, "071315c8-33d2-4479-bb7c-2dc2b1c10f96")]
        public void BeCreatedWithOnlyNumberLongAndId(ulong number, string guid)
        {
            var phone = new Phone(new Guid(guid), number);

            Assert.Equal(guid, phone.Id.ToString());
            Assert.Equal(ushort.Parse(number.ToString().Substring(0, 2)), phone.Ddd);
            Assert.Equal(ulong.Parse(number.ToString().Substring(2)), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData(11234512342)]
        [InlineData(1123452342)]
        public void BeCreatedWithOnlyNumberLong(ulong number)
        {
            var phone = new Phone(number);
            
            Assert.Equal(ushort.Parse(number.ToString().Substring(0, 2)), phone.Ddd);
            Assert.Equal(ulong.Parse(number.ToString().Substring(2)), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData("11234512342")]
        [InlineData("1123452342")]
        public void BeCreatedWithOnlyNumberString(string number)
        {
            var phone = new Phone(number);

            Assert.Equal(ushort.Parse(number.Substring(0, 2)), phone.Ddd);
            Assert.Equal(ulong.Parse(number.Substring(2)), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData("11", "234512342")]
        [InlineData("11", "23452342")]
        public void BeCreatedWithDDDStringAndNumberString(string ddd, string number)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(ushort.Parse(ddd), phone.Ddd);
            Assert.Equal(ulong.Parse(number), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData(11, 234512342)]
        [InlineData(11, 23452342)]
        public void BeCreatedWithDDDShortAndNumberLong(ushort ddd, ulong number)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(ddd, phone.Ddd);
            Assert.Equal(number, phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData(1, 11, 234512342)]
        [InlineData(1, 11, 23452342)]
        public void BeCreatedWithDDIShortDDDShortAndNumberLong(ushort ddi, ushort ddd, ulong number)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(ddd, phone.Ddd);
            Assert.Equal(number, phone.Number);
            Assert.Equal(ddi, phone.Ddi);
        }

        [Theory]
        [InlineData("1", "11", "234512342")]
        [InlineData("1", "11", "23452342")]
        public void BeCreatedWithDDIStringDDDStringAndNumberString(string ddi, string ddd, string number)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(ushort.Parse(ddd), phone.Ddd);
            Assert.Equal(ulong.Parse(number), phone.Number);
            Assert.Equal(ushort.Parse(ddi), phone.Ddi);
        }

        [Theory]
        [InlineData(11, 234512342, "11234512342")]
        [InlineData(11, 23452342, "1123452342")]
        public void HaveRightToString(ushort ddd, ulong number, string value)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(value, phone.ToString());
        }

        [Theory]
        [InlineData(1, 11, 234512342, "111234512342")]
        [InlineData(55, 11, 23452342, "551123452342")]
        [InlineData(320, 11, 23452342, "3201123452342")]
        public void HavaRightToStringWithDdi(ushort ddi, ushort ddd, ulong number, string value)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(value, phone.ToStringWithDdi());
        }
    }
}
