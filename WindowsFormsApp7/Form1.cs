using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PdfCreator pdf = new PdfCreator();
            pdf.CreateCommandPdf("aaaaaa.pdf");

            //cell.SetNextRenderer(new WatermarkedCellRenderer(cell, "Bruno"));
            //PdfFont font = PdfFontFactory.CreateFont(FontProgramFactory.CreateFont(FontConstants.HELVETICA_BOLD));
            //Paragraph para = new Paragraph("Test").SetFont(font);
            //para.SetFixedLeading(0);
            //para.SetMultipliedLeading(1);
            //table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
            //cell.SetHeight(20);
            //cell.SetWidth(100);
            //cell.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            //cell.Add(para);
            //table.AddCell(cell);

        }
    }
}
