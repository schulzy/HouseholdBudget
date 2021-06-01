using System.Collections.Generic;

namespace Schulteisz.Document.Interfaces
{
    public interface IPage
    {
        IEnumerable<string> Lines { get; }
    }
}