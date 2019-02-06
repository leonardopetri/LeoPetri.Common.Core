using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public abstract class PersonDefaultValidator : EntityDefaultValidator<Guid>, IErrorValidator<Person>
    {
        public void GetErrors(Person entity)
        {
            base.GetErrors(entity);

            if (string.IsNullOrWhiteSpace(entity.Name))
                entity.Errors.Add("Name must have a value.");

            if (string.IsNullOrWhiteSpace(entity.CountryId))
                entity.Errors.Add("CountryId must have a value.");
        }
    }
}
