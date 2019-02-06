using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using LeoPetri.Common.Functions;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class LegalEntityDefaultValidator : PersonDefaultValidator, IErrorValidator<LegalEntity>
    {
        public void GetErrors(LegalEntity entity)
        {
            base.GetErrors(entity);
            
            if (CountryIdFunctions.IsCnpjValid(entity.CountryId))
                entity.Errors.Add("CountryId must be a valid Cnpj value.");
        }
    }
}
