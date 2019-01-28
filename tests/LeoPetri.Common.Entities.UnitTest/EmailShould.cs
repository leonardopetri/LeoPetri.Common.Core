using System;
using Xunit;

namespace LeoPetri.Common.Entities.UnitTest
{
    public class EmailShould
    {
        [Fact]
        public void BeCreated()
        {
            var email = new Email("leonardopetri@gmail.com");

            Assert.Equal("leonardopetri@gmail.com", email.Address);
            Assert.Equal("gmail.com", email.Domain);
            Assert.Equal("leonardopetri", email.LocalPart);
        }

        [Fact]
        public void BeCreatedWithError()
        {
            var exception = Assert.Throws<FormatException>(() => new Email("leonardopetrigmail.com"));

            Assert.Equal("Not a valid email address.", exception.Message);
        }
    }
}