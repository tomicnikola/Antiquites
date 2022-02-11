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
    public partial class Periodi : Form
    {
        public Periodi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                int sifra = Convert.ToInt32(textBox1.Text);
                int naziv = Convert.ToInt32(textBox2.Text);
                string insert = "INSERT INTO PERIOD(PeriodID,Period)";
                string values = "VALUES('{0}','{1}')";
                komanda.CommandText = string.Format(insert + values, sifra, naziv);
                try
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Pdaci uspesno uneti!");
                }
                catch
                {
                    MessageBox.Show("Greska");
                }
                konekcija.Close();
            }
            else
            {
                MessageBox.Show("Popunite oba polja!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != ""){
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                int br = Convert.ToInt32(textBox1.Text);
                komanda.CommandText = "DELETE FROM PERIOD WHERE PeriodId="+br;
                try
                {
                    MessageBox.Show("Podaci izbrisani!");
                    komanda.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Greska");
                }
                konekcija.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    OleDbConnection konekcija = new OleDbConnection();
                    konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                    konekcija.Open();
                    OleDbCommand komanda = new OleDbCommand();
                    komanda.Connection = konekcija;
                    int sifra = Convert.ToInt32(textBox1.Text);
                    int naziv = Convert.ToInt32(textBox2.Text);
                    komanda.CommandText = string.Format("UPDATE PERIOD SET Period={0} WHERE PeriodID ={1}", naziv, sifra);
                    try
                    {
                        komanda.ExecuteNonQuery();
                        MessageBox.Show("Pdaci izmenjeni u bazi !");
                    }
                    catch
                    {
                        MessageBox.Show("Greska");
                    }
                    konekcija.Close();
                }
                else
                {
                    MessageBox.Show("Popunite oba polja!");
                }
            }
            catch
            {
                MessageBox.Show("Greska");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT * FROM PERIOD";
                OleDbDataReader reader = komanda.ExecuteReader();
                int br = Convert.ToInt32(textBox1.Text);
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["PeriodID"]);
                    if (br == id)
                    {
                        textBox2.Text = reader["Period"].ToString();
                        break;
                    }
                    else
                    {
                        textBox2.Text = "";
                    }
                }
                konekcija.Close();
            }
            else
            {
                textBox2.Text = "";
            }
        }
    }
}
