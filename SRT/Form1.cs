using System;
using System.Windows.Forms;

namespace SRT
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
