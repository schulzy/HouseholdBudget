using Schulteisz.Document.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UglyToad.PdfPig;

namespace Schulteisz.Document.PdfReader
{
    public class Document : IDocument, IDisposable
    {
        PdfDocument _document = null;
        private IEnumerable<IPage> _pages = new List<IPage>();
        private bool _disposed = false;

        /// <summary>
        /// ctor Document
        /// </summary>
        /// <param name="documentPath">Path of the pdf file</param>
        public Document(string documentPath)
        {
            if (!File.Exists(documentPath))
                throw new ArgumentException($"{nameof(documentPath)} parameter is invalid");

            _document = PdfDocument.Open(documentPath);
            _pages = _document.GetPages().Select(page => new Page(page));
        }

        /// <summary>
        /// ctor Document
        /// </summary>
        /// <param name="documentStream">pdf stream</param>
        public Document(Stream documentStream)
        {
            if (documentStream is null)
                throw new ArgumentNullException($"{documentStream} is null");

            if (documentStream.Length <= 0)
                throw new ArgumentException($"{documentStream} parameter lenght is 0");

            if (documentStream.CanRead)
                throw new ArgumentException($"{documentStream} is not readable");

            _document = PdfDocument.Open(documentStream);
        }

        #region IDisposable
        /// <summary>
        /// Dispose and close the <see cref="Document"/>
        /// </summary>
        public void Dispose() => Dispose(true);
        #endregion

        #region IDocument
        public IEnumerable<IPage> Pages { get { return _pages; } }
        #endregion

        #region Private methods

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                _document?.Dispose();

            _disposed = true;
        } 
        
        #endregion
    }
}
