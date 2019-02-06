using LeoPetri.Common.Core.DafaultValidators;
using LeoPetri.Common.Core.Entities;
using Xunit;

namespace LeoPetri.Common.Core.UnitTest.Entities
{
    public class EmailShould
    {
        public EmailShould()
        {
            Validator.RegisterErrorValidator<Email, EmailDafaultValidator>();
        }

        [Fact]
        public void BeCreated()
        {
            var email = new Email("LEONARDOPETRI@gmail.com");

            Assert.Equal("leonardopetri@gmail.com", email.Address);
            Assert.Equal("gmail.com", email.Domain);
            Assert.Equal("leonardopetri", email.LocalPart);
        }
    }
}
