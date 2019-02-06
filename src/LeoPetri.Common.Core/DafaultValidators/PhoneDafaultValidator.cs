using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class PhoneDafaultValidator : EntityDefaultValidator<Guid>, IErrorValidator<Phone>
    {
        public void GetErrors(Phone entity)
        {
            base.GetErrors(entity);
        }
    }
}
