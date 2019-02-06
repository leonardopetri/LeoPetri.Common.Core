using LeoPetri.Common.Core.Entities;
using LeoPetri.Common.Core.Interfaces;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class AddressDefaultValidator : EntityDefaultValidator<Guid>, IErrorValidator<Address>
    {
        public void GetErrors(Address entity)
        {
            base.GetErrors(entity);

            if (string.IsNullOrWhiteSpace(entity.ZipCode))
            {
                if (string.IsNullOrWhiteSpace(entity.City))
                    entity.Errors.Add("City must have a value.");

                if (entity.State == null)
                    entity.Errors.Add("State must have a value.");
            }
            
            if (string.IsNullOrWhiteSpace(entity.Street))
                entity.Errors.Add("Street must have a value.");

            if (!entity.Number.HasValue)
                entity.Errors.Add("Number must have a value.");

            if (entity.Country == null)
                entity.Errors.Add("Country must have a value.");
        }
    }
}
