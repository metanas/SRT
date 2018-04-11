using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using System;

namespace WindowsFormsApp7
{
    class PdfCreator
    {
        string img = @"C:\Users\Dell\Desktop\LogoNew.png";

        public bool CreateCommandPdf(string fileName, string exp) { 
            PdfDocument pdf = new PdfDocument(new PdfWriter(fileName));
            Document doc = new Document(pdf);
            doc.Add(new Cell().Add(new Image(ImageDataFactory.Create(img)).SetAutoScaleWidth(true)));
            Table table = new Table(1);
            Cell cell = new Cell();
            cell.SetWidth(200);
            cell.SetHeight(50);
            cell.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cell.SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE);
            cell.Add(new Paragraph(exp).SetFontSize(20));
            table.AddCell(cell);
            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
            doc.Add(table);
            Table t = new Table(2);
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Facture: ").SetBold()));
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("aaaa aaaa")));
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Date: ").SetBold()));
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph(DateTime.Now.ToShortDateString())));
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Nos Reference:").SetBold()));
            t.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("nos Reference")));
            doc.Add(t);

            Table t1 = new Table(6);
            t1.SetMarginTop(20);
            t1.SetWidth(520);
            t1.SetBorder(new SolidBorder(1));
            //first
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("№ Remorque:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("")));
            //end first
            //second
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Nbre de colis:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));
            //end second
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Métre(s) de plancher:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));
            //end third
            //end fourth
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Expéditeur:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));
            // end fifth
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Poids brut(kg):").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));
            // end sixth
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Volume (m3):").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));

            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("C-Vente:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));

            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Poids taxable:").SetBold()));
            t1.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("test")));

            doc.Add(t1);

            Table t2 = new Table(3);
            t2.SetMarginTop(50);
            t2.AddCell(new Cell().Add(new Paragraph("Description").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold()).SetWidth(300));
            t2.AddCell(new Cell().Add(new Paragraph("Montant €").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold()).SetWidth(110));
            t2.AddCell(new Cell().Add(new Paragraph("Montant en DHS").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold()).SetWidth(110));

            t2.AddCell(new Cell().Add(new Paragraph("Test \n test \n rrrrr").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)).SetWidth(110));
            t2.AddCell(new Cell().Add(new Paragraph("100").SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)).SetWidth(110));
            t2.AddCell(new Cell().Add(new Paragraph("1000").SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)).SetWidth(110));

            t2.AddCell(new Cell(0,2).Add(new Paragraph("Total").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)));
            t2.AddCell(new Cell().Add(new Paragraph("9800dhs").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)).SetWidth(110));

            doc.Add(t2);
            doc.Add(new Paragraph("Facture en DH\nTVA Exonérée article 92-I-35 du C.G.I").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetMarginTop(20));
            Table t3 = new Table(2);
            t3.SetBorder(Border.NO_BORDER);
            t3.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            t3.SetMarginTop(20);
            t3.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Arrêté la présente la facture á la somme de: ").SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)));
            t3.AddCell(new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph("Arrêté la présente la facture á la somme de: ")));
            doc.Add(t3);
            doc.Add(new Paragraph("Lotis Daoudia № 40 Tanger\nGSM 0639717913 Tel 0539371806\nRC90246 PAT50424378 CNSS 9583081 -IC 000369560000076 ").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetMarginTop(20));
            doc.Close();
            return true;
        }
    }
}
