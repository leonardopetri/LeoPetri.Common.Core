using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Functions;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class LegalEntityDefaultValidator : PersonDefaultValidator, IValidator<LegalEntity>
    {
        public void GetBrokenRules(LegalEntity entity)
        {
            base.GetBrokenRules(entity);
            
            if (CountryIdFunctions.IsCnpjValid(entity.CountryId))
                entity.BrokenRules.Add("CountryId must be a valid Cnpj value.");
        }
    }
}
