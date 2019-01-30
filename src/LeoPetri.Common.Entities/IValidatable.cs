using System.Collections.Generic;

namespace LeoPetri.Common.Core
{
    public interface IValidatable
    {
        IList<string> BrokenRules { get; set; }
    }
}
