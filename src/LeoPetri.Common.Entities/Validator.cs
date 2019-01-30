using System;
using System.Collections.Generic;
using System.Linq;

namespace LeoPetri.Common.Core
{
    public static class Validator
    {
        private static ICollection<Tuple<Type, object>> _validators = new List<Tuple<Type, object>>();

        public static void RegisterValidator<TEntity, TValidator>()
            where TEntity : Entity
            where TValidator : IValidator<TEntity>, new()
        {
            if (_validators.Where(validator => validator.Item1.Equals(typeof(TEntity)) && validator.Item2.Equals(typeof(TValidator))).Any())
                throw new ArgumentException($"Validator {typeof(TValidator).ToString()} already registered for entity {typeof(TEntity).ToString()}");

            _validators.Add(new Tuple<Type, object>(typeof(TEntity), Activator.CreateInstance(typeof(TValidator)) as IValidator<TEntity>));
        }

        private static IEnumerable<Tuple<Type, object>> GetValidators<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            return _validators.Where(validator => validator.Item1.Equals(entity.GetType())).ToList();
        }

        public static bool Validate<TEntity>(this TEntity entity)
            where TEntity : Entity
        {
            var validators = GetValidators(entity);

            foreach (var validator in validators)
            {
                (validator.Item2 as IValidator<TEntity>)?.GetBrokenRules(entity);
            }

            return !entity.BrokenRules.Any();
        }
    }
}
