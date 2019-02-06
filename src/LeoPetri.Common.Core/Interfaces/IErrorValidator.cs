namespace LeoPetri.Common.Core.Interfaces
{
    public interface IErrorValidator<TEntity>
        where TEntity : Entity
    {
        void GetErrors(TEntity entity);
    }
}
