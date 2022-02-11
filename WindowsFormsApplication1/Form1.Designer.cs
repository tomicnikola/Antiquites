namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipAntikvitetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalitetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poArheologuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poTipuArtkvitetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.lokalitetiToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipAntikvitetaToolStripMenuItem,
            this.periodiToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // tipAntikvitetaToolStripMenuItem
            // 
            this.tipAntikvitetaToolStripMenuItem.Name = "tipAntikvitetaToolStripMenuItem";
            this.tipAntikvitetaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tipAntikvitetaToolStripMenuItem.Text = "Tip antikviteta";
            this.tipAntikvitetaToolStripMenuItem.Click += new System.EventHandler(this.tipAntikvitetaToolStripMenuItem_Click);
            // 
            // periodiToolStripMenuItem
            // 
            this.periodiToolStripMenuItem.Name = "periodiToolStripMenuItem";
            this.periodiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.periodiToolStripMenuItem.Text = "Periodi";
            this.periodiToolStripMenuItem.Click += new System.EventHandler(this.periodiToolStripMenuItem_Click);
            // 
            // lokalitetiToolStripMenuItem
            // 
            this.lokalitetiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poArheologuToolStripMenuItem,
            this.poTipuArtkvitetaToolStripMenuItem});
            this.lokalitetiToolStripMenuItem.Name = "lokalitetiToolStripMenuItem";
            this.lokalitetiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lokalitetiToolStripMenuItem.Text = "Lokaliteti";
            // 
            // poArheologuToolStripMenuItem
            // 
            this.poArheologuToolStripMenuItem.Name = "poArheologuToolStripMenuItem";
            this.poArheologuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.poArheologuToolStripMenuItem.Text = "Po arheologu";
            this.poArheologuToolStripMenuItem.Click += new System.EventHandler(this.poArheologuToolStripMenuItem_Click);
            // 
            // poTipuArtkvitetaToolStripMenuItem
            // 
            this.poTipuArtkvitetaToolStripMenuItem.Name = "poTipuArtkvitetaToolStripMenuItem";
            this.poTipuArtkvitetaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.poTipuArtkvitetaToolStripMenuItem.Text = "Po tipu artkviteta";
            this.poTipuArtkvitetaToolStripMenuItem.Click += new System.EventHandler(this.poTipuArtkvitetaToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipAntikvitetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalitetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poArheologuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poTipuArtkvitetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

