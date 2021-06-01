using System.Collections.Generic;

namespace Schulteisz.Document.Interfaces
{
    public interface IDocument
    {
        IEnumerable<IPage> Pages { get; }
    }
}
