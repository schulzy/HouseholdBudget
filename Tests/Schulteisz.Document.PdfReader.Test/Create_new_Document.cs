using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.Document.Interfaces;
using System;

namespace Schulteisz.Document.PdfReader
{
    [TestClass]
    public class Create_new_Document
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A document creation with empty parameter was inappropriately allowed.")]
        public void With_EmptyString_Argument()
        {
            IDocument document = new Document(string.Empty);
        }
    }
}
