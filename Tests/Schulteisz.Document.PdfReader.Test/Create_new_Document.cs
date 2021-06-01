using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.Document.Interfaces;
using System;
using System.IO;
using UglyToad.PdfPig.Core;

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A document creation with wrong path parameter was inappropriately allowed.")]
        public void With_Wrong_Path()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var pdfPath = Path.Combine(baseDir, "notExisting.pdf");
            IDocument document = new Document(pdfPath);
        }

        [TestMethod]
        [ExpectedException(typeof(PdfDocumentFormatException), "A document creation with wrong file parameter was inappropriately allowed.")]
        public void With_Wrong_File()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var pdfPath = Path.Combine(baseDir, "TestData", "dummy.txt");
            IDocument document = new Document(pdfPath);
        }
    }
}
