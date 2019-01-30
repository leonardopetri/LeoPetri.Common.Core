using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Functions;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class NaturalPersonDefaultValidator : PersonDefaultValidator, IValidator<NaturalPerson>
    {
        public void GetBrokenRules(NaturalPerson entity)
        {
            base.GetBrokenRules(entity);

            if (CountryIdFunctions.IsCpfValid(entity.CountryId))
                entity.BrokenRules.Add("CountryId must be a valid Cpf value.");
        }
    }
}
