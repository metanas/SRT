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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            int w = 0;
            MySqlDataReader reader = DBConnect.Gets("select distinct dis, sum(PricePay), count(dis) From command group by dis");
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[w].Cells[0].Value = 1 + w;
                dataGridView1.Rows[w].Cells[1].Value = reader[0].ToString();
                dataGridView1.Rows[w].Cells[2].Value = reader[1].ToString();
                dataGridView1.Rows[w].Cells[3].Value = reader[2].ToString();
                dataGridView1.Rows[w++].Cells[4].Value = "Imprimer";

            }
        }
    }
}
