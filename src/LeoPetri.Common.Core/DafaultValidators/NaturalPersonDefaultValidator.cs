using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using LeoPetri.Common.Functions;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class NaturalPersonDefaultValidator : PersonDefaultValidator, IErrorValidator<NaturalPerson>
    {
        public void GetErrors(NaturalPerson entity)
        {
            base.GetErrors(entity);

            if (CountryIdFunctions.IsCpfValid(entity.CountryId))
                entity.Errors.Add("CountryId must be a valid Cpf value.");
        }
    }
}
