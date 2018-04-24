using iText.IO.Font;
using iText.IO.Image;
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
            DBConnect db = new DBConnect();
            Gain();
            Client();
        }


        private void Client()
        {  
            Cliente.LabelText = DBConnect.Get("SELECT count(distinct dis) FROM command");
        }

        private void Gain()
        {
            float prixPaye = float.Parse(DBConnect.Get("Select sum(PricePay) FROM command"));
            float priceImpaye = float.Parse(DBConnect.Get("SELECT sum(montantDhs) FROM description"));
            paid.LabelText = prixPaye.ToString();
            impaid.LabelText = priceImpaye.ToString();

            float sum = prixPaye - priceImpaye;
            if (sum < 0) {
                gaint.colorActive = Color.DarkRed;
                gaint.color = Color.DarkRed;
                gaint.BackColor = Color.DarkRed;
            }
            else
            {
                gaint.colorActive = Color.SeaGreen;
                gaint.color = Color.SeaGreen;
                gaint.BackColor = Color.SeaGreen;
            }
        
            gaint.LabelText = (prixPaye - priceImpaye).ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            command.TopLevel = false;
            command.Parent = panel2;
            command.Dock = DockStyle.Fill;
            command.Show();   
        }
    }
}
