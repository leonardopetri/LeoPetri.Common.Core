using System.Collections.Generic;

namespace LeoPetri.Common.Core.Interfaces
{
    public interface IWarningValidatable
    {
        IList<string> Warnings { get; set; }
    }
}
