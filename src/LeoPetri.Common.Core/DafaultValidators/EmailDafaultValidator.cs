using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using LeoPetri.Common.Functions;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class EmailDafaultValidator : EntityDefaultValidator<Guid>, IErrorValidator<Email>
    {
        public void GetErrors(Email entity)
        {
            base.GetErrors(entity);

            if (!EmailFunctions.IsValid(entity.Address))
                entity.Errors.Add("Not a valid email address.");
        }
    }
}
