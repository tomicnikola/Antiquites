using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipAntikvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipAntikviteta forma = new TipAntikviteta();
            forma.ShowDialog();
        }

        private void poArheologuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoArheologu forma = new PoArheologu();
            forma.ShowDialog();
        }

        private void periodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodi forma = new Periodi();
            forma.ShowDialog();
        }

        private void poTipuArtkvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoTA forma = new PoTA();
            forma.ShowDialog();
        }

        
    }
}
