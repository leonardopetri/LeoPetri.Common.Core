using LeoPetri.Common.Core.Entities;
using System;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public class AddressDefaultValidator : EntityDefaultValidator<Guid>, IValidator<Address>
    {
        public void GetBrokenRules(Address entity)
        {
            base.GetBrokenRules(entity);

            if (string.IsNullOrWhiteSpace(entity.ZipCode))
            {
                if (string.IsNullOrWhiteSpace(entity.City))
                    entity.BrokenRules.Add("City must have a value.");

                if (entity.State == null)
                    entity.BrokenRules.Add("State must have a value.");
            }
            
            if (string.IsNullOrWhiteSpace(entity.Street))
                entity.BrokenRules.Add("Street must have a value.");

            if (!entity.Number.HasValue)
                entity.BrokenRules.Add("Number must have a value.");

            if (entity.Country == null)
                entity.BrokenRules.Add("Country must have a value.");
        }
    }
}
