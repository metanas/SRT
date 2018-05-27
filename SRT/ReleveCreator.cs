using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT
{
    class ReleveCreator
    {
        string img = @"C:\Users\Dell\Desktop\LogoNew.png";
        public bool CreateRelevePdf(string fileName)
        {
            PdfDocument pdf = new PdfDocument(new PdfWriter("Releve_" + fileName + ".pdf"));
            Document doc = new Document(pdf);
            doc.Add(new Cell().Add(new Image(ImageDataFactory.Create(img)).SetAutoScaleWidth(true)));
            return true;
        }
    }
}
