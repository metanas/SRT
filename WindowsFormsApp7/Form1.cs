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
        static Form  Active;
        public Form1()
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            Stactistique stactistique = new Stactistique();
            openForm(stactistique, panel2);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            openForm(command, panel2);
        }

        public static void openForm(Form form, Control panel2)
        {
            if (Active != null) Active.Close();
            Active = form;
            form.TopLevel = false;
            form.Parent = panel2;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           openForm(new Stactistique(), panel2);
        }
    }
}
