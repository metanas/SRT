using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class PdfCreator
    {
        string img = @"C:\Users\Dell\Desktop\LogoNew.png";

        public bool CreateCommandPdf(string fileName) { 
            PdfDocument pdf = new PdfDocument(new PdfWriter(fileName));
            Document doc = new Document(pdf);

            doc.Add(new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(img)).SetAutoScaleWidth(true)));
            return true;
        }
    }
}
