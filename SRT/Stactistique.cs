using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRT
{
    public partial class Stactistique : Form
    {
        public Stactistique()
        {
            InitializeComponent();
            Gain();
            Client();
            Impaye();
        }

        private void Impaye()
        {
            int im = 0;
            int pay = 0;
            MySqlDataReader dataReader = DBConnect.Gets("SELECT sum(montantDhs) as w, PricePay FROM command c Left join description d on(c.id = d.command) group by c.id");
            while (dataReader.Read())
            {
                if(float.Parse(dataReader[0].ToString()) - float.Parse(dataReader[1].ToString()) > 0)
                {
                    im += 1;
                }
                else
                {
                    pay += 1;
                }
            }
            paid.LabelText = pay.ToString();
            impaid.LabelText = im.ToString();
        }

        private void Paye()
        {
            DBConnect.Get("SELECT count(*) FROM description d Left join command c on (c.id = d.command) where d.montantDhs - c.PricePay = 0");

        }
        private void Client()
        {
            Cliente.LabelText = DBConnect.Get("SELECT count(distinct dis) FROM command");
        }

        private void Gain()
        {
            float prixPaye = float.Parse(DBConnect.Get("Select sum(PricePay) FROM command"));
            float priceImpaye = float.Parse(DBConnect.Get("SELECT count(montantDhs) FROM description "));

            float sum = prixPaye - priceImpaye;
            if (sum < 0)
            {
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

        private void impaid_Click(object sender, EventArgs e)
        {
            Form1.openForm(new Impayer(true), this.Parent);
        }

        private void paid_Click(object sender, EventArgs e)
        {
            Form1.openForm(new Impayer(false), this.Parent);
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            Form1.openForm(new Client(), this.Parent);
        }
    }
}
