namespace LeoPetri.Common.Core.Interfaces
{
    public interface IWarningValidator<TEntity>
        where TEntity : Entity
    {
        void GetWarnings(TEntity entity);
    }
}
