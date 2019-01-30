namespace LeoPetri.Common.Core
{
    public interface IValidator<TEntity>
        where TEntity : Entity
    {
        void GetBrokenRules(TEntity entity);
    }
}
