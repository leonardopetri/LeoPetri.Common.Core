using LeoPetri.Common.Core.Interfaces;

namespace LeoPetri.Common.Core.DafaultValidators
{
    public abstract class EntityDefaultValidator<TId> : IErrorValidator<Entity<TId>>
        where TId : struct
    {
        public void GetErrors(Entity<TId> entity)
        {
            if (default(TId).Equals(entity.Id))
                entity.Errors.Add("Not valid a Id value.");
        }
    }
}
