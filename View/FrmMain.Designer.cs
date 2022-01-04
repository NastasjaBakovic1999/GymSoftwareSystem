namespace View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviKorisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviTerminiUslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoveTermineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoveRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.uslugeToolStripMenuItem,
            this.rezervacijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviKorisniciToolStripMenuItem,
            this.dodajNovogKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // sviKorisniciToolStripMenuItem
            // 
            this.sviKorisniciToolStripMenuItem.Name = "sviKorisniciToolStripMenuItem";
            this.sviKorisniciToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.sviKorisniciToolStripMenuItem.Text = "Svi korisnici";
            this.sviKorisniciToolStripMenuItem.Click += new System.EventHandler(this.sviKorisniciToolStripMenuItem_Click);
            // 
            // dodajNovogKorisnikaToolStripMenuItem
            // 
            this.dodajNovogKorisnikaToolStripMenuItem.Name = "dodajNovogKorisnikaToolStripMenuItem";
            this.dodajNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.dodajNovogKorisnikaToolStripMenuItem.Text = "Dodaj novog korisnika";
            this.dodajNovogKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogKorisnikaToolStripMenuItem_Click);
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveUslugeToolStripMenuItem,
            this.sviTerminiUslugaToolStripMenuItem,
            this.dodajNoveTermineToolStripMenuItem});
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            this.uslugeToolStripMenuItem.Click += new System.EventHandler(this.uslugeToolStripMenuItem_Click);
            // 
            // sveUslugeToolStripMenuItem
            // 
            this.sveUslugeToolStripMenuItem.Name = "sveUslugeToolStripMenuItem";
            this.sveUslugeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sveUslugeToolStripMenuItem.Text = "Sve usluge";
            this.sveUslugeToolStripMenuItem.Click += new System.EventHandler(this.sveUslugeToolStripMenuItem_Click);
            // 
            // sviTerminiUslugaToolStripMenuItem
            // 
            this.sviTerminiUslugaToolStripMenuItem.Name = "sviTerminiUslugaToolStripMenuItem";
            this.sviTerminiUslugaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sviTerminiUslugaToolStripMenuItem.Text = "Svi termini usluga";
            this.sviTerminiUslugaToolStripMenuItem.Click += new System.EventHandler(this.sviTerminiUslugaToolStripMenuItem_Click);
            // 
            // dodajNoveTermineToolStripMenuItem
            // 
            this.dodajNoveTermineToolStripMenuItem.Name = "dodajNoveTermineToolStripMenuItem";
            this.dodajNoveTermineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajNoveTermineToolStripMenuItem.Text = "Dodaj nove termine";
            this.dodajNoveTermineToolStripMenuItem.Click += new System.EventHandler(this.dodajNoveTermineToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveRezervacijeToolStripMenuItem,
            this.dodajNoveRezervacijeToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // sveRezervacijeToolStripMenuItem
            // 
            this.sveRezervacijeToolStripMenuItem.Name = "sveRezervacijeToolStripMenuItem";
            this.sveRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.sveRezervacijeToolStripMenuItem.Text = "Sve rezervacije";
            this.sveRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.sveRezervacijeToolStripMenuItem_Click);
            // 
            // dodajNoveRezervacijeToolStripMenuItem
            // 
            this.dodajNoveRezervacijeToolStripMenuItem.Name = "dodajNoveRezervacijeToolStripMenuItem";
            this.dodajNoveRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.dodajNoveRezervacijeToolStripMenuItem.Text = "Dodaj nove rezervacije";
            this.dodajNoveRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.dodajNoveRezervacijeToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::View.Properties.Resources.gym_wall;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1145, 631);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 656);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teretana Terminator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem sveUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoveTermineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sveRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoveRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviKorisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviTerminiUslugaToolStripMenuItem;
    }
}