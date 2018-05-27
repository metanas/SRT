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
    public partial class Releve : Form
    {
        String dis;
        public Releve(String dis)
        {
            InitializeComponent();
            this.dis = dis;
        }



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Releve_Load(object sender, EventArgs e)
        {
            MySqlDataReader dataReader = DBConnect.Gets("select Max(lDate), min(lDate) from command where dis='" + dis + "'");
            if (dataReader.Read())
            {
                dateTimePicker1.MinDate = DateTime.Parse(dataReader[1].ToString());
                dateTimePicker1.Value = DateTime.Parse(dataReader[1].ToString());
                dateTimePicker2.MinDate = DateTime.Parse(dataReader[1].ToString());
                dateTimePicker1.MaxDate = DateTime.Parse(dataReader[0].ToString());
                dateTimePicker2.MaxDate = DateTime.Parse(dataReader[0].ToString());
                dateTimePicker2.Value = DateTime.Parse(dataReader[0].ToString());
            }
            dataReader.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String d = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MySqlDataReader dataReader = DBConnect.Gets("select * from command where dis='" + dis + "' and lDate >= '"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and lDate <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'");
            while (dataReader.Read())
            {
                String s = dataReader[1].ToString();
            }
        }
    }
}
