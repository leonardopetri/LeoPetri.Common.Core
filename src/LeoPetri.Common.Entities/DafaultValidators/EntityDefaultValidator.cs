namespace LeoPetri.Common.Core.DafaultValidators
{
    public abstract class EntityDefaultValidator<TId> : IValidator<Entity<TId>>
        where TId : struct
    {
        public void GetBrokenRules(Entity<TId> entity)
        {
            if (default(TId).Equals(entity.Id))
                entity.BrokenRules.Add("Not valid a Id value.");
        }
    }
}
