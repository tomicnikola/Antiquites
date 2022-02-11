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
    public partial class TipAntikviteta : Form
    {
        public TipAntikviteta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Upis
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Popunite oba polja!");
            }
            else
            {
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                komanda.CommandText = string.Format("INSERT INTO TIP_ANTIKVITETA (TipAntikvitetaID,Tip) VALUES('{0}','{1}')", Convert.ToInt32(textBox1.Text), textBox2.Text);
                try
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podaci uspesno upisani u bazu!");
                    konekcija.Close();
                }
                catch
                {
                    MessageBox.Show("Greska!");
                    konekcija.Close();
                }
            }
        }
        //Brisanje
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Morate uneti sifru!");
            }
            else
            {
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                komanda.CommandText = "DELETE FROM TIP_ANTIKVITETA WHERE TipAntikvitetaID="+Convert.ToInt32(textBox1.Text);
                try
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podatak je uspesno Izbrisan iz baze!");
                    konekcija.Close();
                }
                catch
                {
                    MessageBox.Show("Greska!");
                    konekcija.Close();
                }
            }
        }
        //Izmena
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text=="")
            {
                MessageBox.Show("Morate popuniti oba polja!");
            }
            else
            {
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                komanda.CommandText = string.Format("UPDATE TIP_ANTIKVITETA SET Tip='{0}' WHERE TipAntikvitetaID={1}", textBox2.Text, Convert.ToInt32(textBox1.Text));
                try
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podatak je izmenjen u bazi!");
                    konekcija.Close();
                }
                catch
                {
                    MessageBox.Show("Greska!");
                    konekcija.Close();
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "";
            }
            else
            {
                int sifra = Convert.ToInt32(textBox1.Text);
                OleDbConnection konekcija = new OleDbConnection();
                konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije - osnovno.mdb";
                konekcija.Open();
                OleDbCommand komanda = new OleDbCommand();
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT * FROM TIP_ANTIKVITETA";
                OleDbDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    string tip = reader["TipAntikvitetaID"].ToString();
                    int tipBr = Convert.ToInt32(tip);
                    if (sifra == tipBr)
                    {
                        textBox2.Text = reader["Tip"].ToString();
                        break;
                    }
                    else
                    {
                        textBox2.Text = "";
                    }
                }
                konekcija.Close();
            }

        }

    }
}
