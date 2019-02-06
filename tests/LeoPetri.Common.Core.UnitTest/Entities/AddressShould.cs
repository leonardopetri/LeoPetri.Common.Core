using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.ValueObjects;
using Xunit;

namespace LeoPetri.Common.Core.UnitTest.Entities
{
    public class AddressShould
    {
        [Fact]
        public void BeCreated()
        {
            var address = new Address()
            {
                Street = "rua aimberê",
                District = "vila CuruÇA",
                State = new State() { Name = "são PAULO", Abbreviation = "sP" },
                City = "Santo André",
                Complement = "apto. 72",
                Number = 1010,
                ZipCode = "9080320"
            };

            Assert.Equal("Rua Aimberê, 1010, Apto. 72, Vila Curuça, Santo André - SP, 09080-320", address.ToString());
        }
    }
}
