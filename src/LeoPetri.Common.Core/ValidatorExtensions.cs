using LeoPetri.Common.Core.Interfaces;
using System.Linq;

namespace LeoPetri.Common.Core
{
    public static class ValidatorExtensions
    {
        public static bool HasErrors<TEntity>(this TEntity entity)
            where TEntity : Entity
        {
            var validators = Validator.GetErrorValidators(entity);

            foreach (var v in validators)
            {
                (v.Validator as IErrorValidator<TEntity>)?.GetErrors(entity);
            }

            return !entity.Errors.Any();
        }

        public static bool HasWarnings<TEntity>(this TEntity entity)
            where TEntity : Entity
        {
            var validators = Validator.GetWarningValidators(entity);

            foreach (var v in validators)
            {
                (v.Validator as IWarningValidator<TEntity>)?.GetWarnings(entity);
            }

            return !entity.Warnings.Any();
        }

        public static void Validate<TEntity>(this TEntity entity)
            where TEntity : Entity
        {
            var errorValidators = Validator.GetErrorValidators(entity);
            var warningValidators = Validator.GetWarningValidators(entity);

            foreach (var v in errorValidators)
            {
                (v.Validator as IErrorValidator<TEntity>)?.GetErrors(entity);
            }

            foreach (var v in warningValidators)
            {
                (v.Validator as IWarningValidator<TEntity>)?.GetWarnings(entity);
            }
        }
    }
}
