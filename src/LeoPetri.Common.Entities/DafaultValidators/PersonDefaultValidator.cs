using LeoPetri.Common.Core.Entities;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public abstract class PersonDefaultValidator : EntityDefaultValidator<Guid>, IValidator<Person>
    {
        public void GetBrokenRules(Person entity)
        {
            base.GetBrokenRules(entity);

            if (string.IsNullOrWhiteSpace(entity.Name))
                entity.BrokenRules.Add("Name must have a value.");

            if (string.IsNullOrWhiteSpace(entity.CountryId))
                entity.BrokenRules.Add("CountryId must have a value.");
        }
    }
}
