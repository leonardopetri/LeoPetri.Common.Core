using Xunit;
using LeoPetri.Common.Extensions;
using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.ValueObjects;

namespace LeoPetri.Common.Core.UnitTest.Entities
{
    public class PersonShould
    {
        [Theory]
        [InlineData("leonardo petri da silva", "377.897.884-50")]
        [InlineData("leonardo petri silva", "676.868.407-86")]
        [InlineData("Leonardo Petri Silva", "289.774.061-29")]
        [InlineData("LEONARDO PETRI", "42623257922")]
        public void BeCreatedAsNaturalPerson(string name, string countryId)
        {
            var naturalPerson = new NaturalPerson();

            Assert.Equal(PersonType.NaturalPerson, naturalPerson.Type);

            naturalPerson.Name = name;
            naturalPerson.CountryId = countryId;

            Assert.Equal(name.ToUpperFirstLetterName(), naturalPerson.Name);
            Assert.Equal(countryId.NoSpecialChar(), naturalPerson.CountryId);
        }

        [Theory]
        [InlineData("Lpsoft Tecnologia da Informação Ltda.", "11.288.802/0001-65")]
        [InlineData("LPSOFT TECNOLOGIA DA INFORMAÇÃO LTDA.", "36.143.935/0001-74")]
        [InlineData("lpsoft tenolocia ltda", "54.018.514/0001-01")]
        [InlineData("lps", "16638201000159")]
        public void BeCreatedAsLegalEntity(string name, string countryId)
        {
            var legalEntity = new LegalEntity();

            Assert.Equal(PersonType.LegalEntity, legalEntity.Type);

            legalEntity.Name = name;
            legalEntity.CountryId = countryId;

            Assert.Equal(name.ToUpperFirstLetterName(), legalEntity.Name);
            Assert.Equal(countryId.NoSpecialChar(), legalEntity.CountryId);
        }
    }
}
