using LeoPetri.Common.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeoPetri.Common.Core
{
    public static class Validator
    {
        private static ICollection<(Type Entity, object Validator)> _errorValidators = new List<(Type Entity, object Validator)>();
        private static ICollection<(Type Entity, object Validator)> _warningValidators = new List<(Type Entity, object Validator)>();

        public static void RegisterErrorValidator<TEntity, TValidator>()
            where TEntity : Entity
            where TValidator : IErrorValidator<TEntity>, new()
        {
            if (_errorValidators.Where(v => v.Entity.Equals(typeof(TEntity)) && v.Validator.GetType().Equals(typeof(TValidator))).Any())
                throw new ArgumentException($"Validator {typeof(TValidator).ToString()} already registered for entity {typeof(TEntity).ToString()}");

            _errorValidators.Add((typeof(TEntity), Activator.CreateInstance(typeof(TValidator)) as IErrorValidator<TEntity>));
        }

        public static void RegisterWarningValidator<TEntity, TValidator>()
            where TEntity : Entity
            where TValidator : IWarningValidator<TEntity>, new()
        {
            if (_warningValidators.Where(v => v.Entity.Equals(typeof(TEntity)) && v.Validator.GetType().Equals(typeof(TValidator))).Any())
                throw new ArgumentException($"Validator {typeof(TValidator).ToString()} already registered for entity {typeof(TEntity).ToString()}");

            _warningValidators.Add((typeof(TEntity), Activator.CreateInstance(typeof(TValidator)) as IWarningValidator<TEntity>));
        }

        internal static ICollection<(Type Entity, object Validator)> GetErrorValidators<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            return _errorValidators.Where(v => v.Entity.Equals(entity.GetType())).ToList();
        }

        internal static ICollection<(Type Entity, object Validator)> GetWarningValidators<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            return _warningValidators.Where(v => v.Entity.Equals(entity.GetType())).ToList();
        }
    }
}
