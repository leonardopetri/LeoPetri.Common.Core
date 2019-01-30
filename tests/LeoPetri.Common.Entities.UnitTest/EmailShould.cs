using LeoPetri.Common.Core.DafaultValidators;
using LeoPetri.Common.Core.Entities;
using System.Linq;
using Xunit;

namespace LeoPetri.Common.Core.UnitTest
{
    public class EmailShould
    {
        public EmailShould()
        {
            Validator.RegisterValidator<Email, EmailDafaultValidator>();
        }

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
            var email = new Email("leonardopetrigmail.com");
            
            var isValid = email.Validate();

            Assert.Equal("Not a valid email address.", email.BrokenRules.ToList()[0]);
        }
    }
}
