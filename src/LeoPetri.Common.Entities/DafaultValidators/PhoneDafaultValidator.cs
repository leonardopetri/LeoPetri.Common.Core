using LeoPetri.Common.Core.Entities;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class PhoneDafaultValidator : EntityDefaultValidator<Guid>, IValidator<Phone>
    {
        public void GetBrokenRules(Phone entity)
        {
            base.GetBrokenRules(entity);
        }
    }
}
