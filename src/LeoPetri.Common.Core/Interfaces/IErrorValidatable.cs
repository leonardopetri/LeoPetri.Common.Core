using System.Collections.Generic;

namespace LeoPetri.Common.Core.Interfaces
{
    public interface IErrorValidatable
    {
        IList<string> Errors { get; set; }
    }
}
