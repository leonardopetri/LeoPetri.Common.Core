using LeoPetri.Common.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeoPetri.Common.Core
{
    public abstract class Command : IErrorValidatable
    {
        public readonly Guid Id;

        public Command()
        {
            this.Id = Guid.NewGuid();
        }

        public IList<string> Errors { get; set; }

        protected abstract void Validate();

        public bool IsValid()
        {
            this.Validate();
            return !this.Errors.Any();
        }
    }
}
