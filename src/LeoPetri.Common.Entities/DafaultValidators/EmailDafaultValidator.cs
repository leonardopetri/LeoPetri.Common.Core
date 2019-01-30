using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class EmailDafaultValidator : EntityDefaultValidator<Guid>, IValidator<Email>
    {
        public void GetBrokenRules(Email entity)
        {
            base.GetBrokenRules(entity);

            if (!EmailFunctions.IsValid(entity.Address))
                entity.BrokenRules.Add("Not a valid email address.");
        }
    }
}
