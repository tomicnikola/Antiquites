using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class PoArheologu : Form
    {
        public PoArheologu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int id;
        OleDbDataAdapter da;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != ""){
                    button2.Enabled = true;
                    OleDbConnection konekcija = new OleDbConnection();
                    konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                    konekcija.Open();
                    OleDbCommand komanda = new OleDbCommand();
                    komanda.Connection = konekcija;
                    string prvo = "SELECT Lokalitet.LokalitetID,Lokalitet.KoordinateDuzina,Lokalitet.KoordinateSirina ";
                    string drugo = "FROM ((Antikvitet INNER JOIN Arheolog ON Antikvitet.ArheologID=Arheolog.ArheologID)INNER JOIN Lokalitet ON Antikvitet.LokalitetID=Lokalitet.LokalitetID) WHERE(Arheolog.ArheologID={0})";
                    komanda.CommandText = string.Format(prvo + drugo, Convert.ToInt32(textBox1.Text));
                    da.SelectCommand = komanda;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    konekcija.Close();
                }
            }
            catch
            {
                MessageBox.Show("Greska!");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string duzina = dt.Rows[id]["KoordinateDuzna"].ToString();
                string sirina = dt.Rows[id]["KoordinateSirina"].ToString();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

                string[] si = sirina.Split(' ');
                string[] du = duzina.Split(' ');
                double x = 0;
                double y = 0;
                if (du[1] == "IGD")
                {
                    x = Convert.ToDouble(du[0]);
                }
                else
                {
                    x = -Convert.ToDouble(du[0]);
                }
                if(si[1]=="SGS"){
                    y = -Convert.ToDouble(si[0]);
                }

                Pen olovka = new Pen(Color.Red,3);
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                g.DrawRectangle(olovka,0,0,pictureBox1.Height-1,pictureBox1.Width-1);
                g.DrawLine(olovka,pictureBox1.Width/2,0,pictureBox1.Width/2,pictureBox1.Height);
                g.DrawLine(olovka,0,pictureBox1.Height/2,pictureBox1.Width,pictureBox1.Height/2);
                g.DrawEllipse(olovka, pictureBox1.Width / 2 + ((int)x - 5), pictureBox1.Height / 2 + ((int)y - 5), 5, 5);
            }

            catch
            {
                MessageBox.Show("Greska");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
        }
    }
}
