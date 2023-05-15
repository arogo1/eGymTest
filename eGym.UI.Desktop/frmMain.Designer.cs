namespace eGym.UI.Desktop
{
    partial class frmMain
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
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planIshraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahtjevZaTerminimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRasporedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uposleniciToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.planIshraneToolStripMenuItem,
            this.planTreningaToolStripMenuItem,
            this.zahtjevZaTerminimaToolStripMenuItem,
            this.pregledRasporedaToolStripMenuItem,
            this.izjestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.uposleniciToolStripMenuItem.Text = "Uposlenici";
            this.uposleniciToolStripMenuItem.Click += new System.EventHandler(this.uposleniciToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // planIshraneToolStripMenuItem
            // 
            this.planIshraneToolStripMenuItem.Name = "planIshraneToolStripMenuItem";
            this.planIshraneToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.planIshraneToolStripMenuItem.Text = "Plan ishrane";
            this.planIshraneToolStripMenuItem.Click += new System.EventHandler(this.planIshraneToolStripMenuItem_Click);
            // 
            // planTreningaToolStripMenuItem
            // 
            this.planTreningaToolStripMenuItem.Name = "planTreningaToolStripMenuItem";
            this.planTreningaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.planTreningaToolStripMenuItem.Text = "Plan treninga";
            this.planTreningaToolStripMenuItem.Click += new System.EventHandler(this.planTreningaToolStripMenuItem_Click);
            // 
            // zahtjevZaTerminimaToolStripMenuItem
            // 
            this.zahtjevZaTerminimaToolStripMenuItem.Name = "zahtjevZaTerminimaToolStripMenuItem";
            this.zahtjevZaTerminimaToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.zahtjevZaTerminimaToolStripMenuItem.Text = "Rezervacije";
            this.zahtjevZaTerminimaToolStripMenuItem.Click += new System.EventHandler(this.zahtjevZaTerminimaToolStripMenuItem_Click);
            // 
            // izjestajiToolStripMenuItem
            // 
            this.izjestajiToolStripMenuItem.Name = "izjestajiToolStripMenuItem";
            this.izjestajiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.izjestajiToolStripMenuItem.Text = "Izvjestaji";
            this.izjestajiToolStripMenuItem.Click += new System.EventHandler(this.izjestajiToolStripMenuItem_Click);
            // 
            // pregledRasporedaToolStripMenuItem
            // 
            this.pregledRasporedaToolStripMenuItem.Name = "pregledRasporedaToolStripMenuItem";
            this.pregledRasporedaToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.pregledRasporedaToolStripMenuItem.Text = "Pregled rasporeda";
            this.pregledRasporedaToolStripMenuItem.Click += new System.EventHandler(this.pregledRasporedaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Meni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uposleniciToolStripMenuItem;
        private ToolStripMenuItem korisniciToolStripMenuItem;
        private ToolStripMenuItem planIshraneToolStripMenuItem;
        private ToolStripMenuItem planTreningaToolStripMenuItem;
        private ToolStripMenuItem zahtjevZaTerminimaToolStripMenuItem;
        private ToolStripMenuItem izjestajiToolStripMenuItem;
        private ToolStripMenuItem pregledRasporedaToolStripMenuItem;
    }
}