using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRT
{
    public partial class Command : Form
    {
        public Command()
        {
            InitializeComponent();
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            List<String> list = new List<string>();
            List<String> list2 = new List<string>();
            List<float> list3 = new List<float>();
            String des = Desti.Text;
            if (textBox1.Text != "") dictionary["№ Remorque:"] = textBox1.Text; 
            if (textBox2.Text != "") dictionary["Nbre de colis:"] = textBox2.Text; else textBox2.Text = "0" ;
            if (textBox3.Text != "") dictionary["Métre(s) de plancher:"] = textBox3.Text; else textBox3.Text = "0";
            if (textBox4.Text != "") dictionary["Expéditeur:"] = textBox4.Text;
            if (textBox5.Text != "") dictionary["Poids brut(kg):"] = textBox5.Text; else textBox5.Text = "0";
            if (textBox6.Text != "") dictionary["Volume (m3):"] = textBox6.Text; else textBox6.Text = "0";
            if (textBox7.Text != "") dictionary["C-Vente:"] = textBox7.Text;
            if (textBox8.Text != "") dictionary["Poids taxable:"] = textBox8.Text; else textBox8.Text = "0";
            
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                list2.Add((dataGridView1.Rows[i].Cells[1].Value == null) ? "0" : dataGridView1.Rows[i].Cells[1].Value.ToString());
                list3.Add(float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {

                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PdfCreator pdfCreator = new PdfCreator();
                    String d = DateTime.Now.ToString("yyyy-MM-dd");
                    DBConnect.Post("Insert into command (dis, nFacture, lDate, ref, Remorque, NBrColis, Metre, Expi, volume,  PoidsPrut, CVente, poidtaxe) Values('" + des + "', '" + 1000 + "','" + d + "', 'ref to change', '" + textBox1.Text  + "', '" + textBox2.Text.ToString()  + "', '" + textBox3.Text.ToString() + "' ,'" + textBox4.Text + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "' , '" + textBox7.Text + "' , '" + textBox8.Text.ToString() + "')");
                    String id = DBConnect.Get("SELECT max(id) FROM command");
                    for (int i=0; i< list.Count; i++)
                        DBConnect.Post("INSERT INTO description (dis, montantEuro, montantDhs, command) values ('" + list[i] + "', '" + list2[i] + "', '" + list3[i] + "', '" + id + "')" );
                    pdfCreator.CreateCommandPdf(dlg.SelectedPath + "\\" + des + DateTime.Now.ToString("dd/mm/yy"), des, "", "", dictionary, list, list2, list3);
                    MessageBox.Show("Facture est bien generee");
                }
            }
           
        }
    }
}
