using Schulteisz.Document.Interfaces;
using System;
using System.Collections.Generic;

namespace Schulteisz.Document.PdfReader
{
    public class Page : IPage
    {
        private UglyToad.PdfPig.Content.Page _page;
        private IEnumerable<string> _lines;

        public Page(UglyToad.PdfPig.Content.Page page)
        {
            _page = page;
        }

        public IEnumerable<string> Lines
        {
            get
            {
                if (_lines is null)
                    InitPages();

                return _lines;
            }
        }

        private void InitPages()
        {
            throw new NotImplementedException();
        }
    }
}
