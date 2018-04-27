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
    public partial class Impayer : Form
    {
        bool paid;
        public Impayer(bool paid)
        {
            InitializeComponent();
            this.paid = paid;
        }

        private void Impayer_Load(object sender, EventArgs e)
        {
            int w = 0;
            pictureBox1.Image = (paid) ? SRT.Properties.Resources.real_estate_malta_5 : SRT.Properties.Resources.Tcm_Paid_stamp_300x183;
            MySqlDataReader dataReader = DBConnect.Gets("SELECT c.dis, nFacture, Expi, sum(montantDhs) as w, PricePay, imageConfermation FROM command c Left join description d on(c.id = d.command) group by c.id");
            while (dataReader.Read())
            {
                if (float.Parse(dataReader[3].ToString()) - float.Parse(dataReader[4].ToString()) > 0 && paid)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[w].Cells[0].Value = dataReader[0].ToString();
                    dataGridView1.Rows[w].Cells[1].Value = dataReader[1].ToString();
                    dataGridView1.Rows[w].Cells[2].Value = dataReader[2].ToString();
                    dataGridView1.Rows[w].Cells[3].Value = dataReader[3].ToString();
                    dataGridView1.Rows[w].Cells[4].Value = dataReader[4].ToString();
                    dataGridView1.Rows[w++].Cells[6].Value = "Imprimer";
                }
                if (float.Parse(dataReader[3].ToString()) - float.Parse(dataReader[4].ToString()) <= 0 && !paid)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[w].Cells[0].Value = dataReader[0].ToString();
                    dataGridView1.Rows[w].Cells[1].Value = dataReader[1].ToString();
                    dataGridView1.Rows[w].Cells[2].Value = dataReader[2].ToString();
                    dataGridView1.Rows[w].Cells[3].Value = dataReader[3].ToString();
                    dataGridView1.Rows[w].Cells[4].Value = dataReader[4].ToString();
                    dataGridView1.Rows[w++].Cells[6].Value = "Imprimer";
                }
            }
        }
    }
}
