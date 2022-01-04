namespace View.UserControls
{
    partial class UCKorisnici
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnSviKorisnici = new System.Windows.Forms.Button();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDetaljiOKorisniku = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.gbDetaljiOKorisniku.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AllowUserToResizeColumns = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            this.dgvKorisnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.White;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(33, 196);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(533, 402);
            this.dgvKorisnici.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime i prezime korisnika:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.Location = new System.Drawing.Point(260, 82);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(315, 32);
            this.txtPretraga.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.BackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziDetalje.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnPrikaziDetalje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrikaziDetalje.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziDetalje.FlatAppearance.BorderSize = 0;
            this.btnPrikaziDetalje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziDetalje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziDetalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziDetalje.ForeColor = System.Drawing.Color.White;
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(598, 492);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(208, 43);
            this.btnPrikaziDetalje.TabIndex = 10;
            this.btnPrikaziDetalje.Text = "Detalji o korisniku";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = false;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnSviKorisnici
            // 
            this.btnSviKorisnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSviKorisnici.BackColor = System.Drawing.Color.Transparent;
            this.btnSviKorisnici.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnSviKorisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSviKorisnici.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSviKorisnici.FlatAppearance.BorderSize = 0;
            this.btnSviKorisnici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSviKorisnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSviKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSviKorisnici.ForeColor = System.Drawing.Color.White;
            this.btnSviKorisnici.Location = new System.Drawing.Point(142, 131);
            this.btnSviKorisnici.Name = "btnSviKorisnici";
            this.btnSviKorisnici.Size = new System.Drawing.Size(208, 43);
            this.btnSviKorisnici.TabIndex = 9;
            this.btnSviKorisnici.Text = "Prikaži sve korisnike";
            this.btnSviKorisnici.UseVisualStyleBackColor = false;
            this.btnSviKorisnici.Click += new System.EventHandler(this.btnSviKorisnici_Click);
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiKorisnika.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiKorisnika.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnObrisiKorisnika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiKorisnika.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiKorisnika.FlatAppearance.BorderSize = 0;
            this.btnObrisiKorisnika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiKorisnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiKorisnika.ForeColor = System.Drawing.Color.White;
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(598, 555);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(208, 43);
            this.btnObrisiKorisnika.TabIndex = 7;
            this.btnObrisiKorisnika.Text = "Obriši korisnika";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = false;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(368, 131);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(207, 43);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(187, 237);
            this.dtpDatumRodjenja.MaxDate = new System.DateTime(2021, 12, 30, 0, 0, 0, 0);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(295, 32);
            this.dtpDatumRodjenja.TabIndex = 20;
            this.dtpDatumRodjenja.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(187, 298);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(295, 32);
            this.txtAdresa.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ime";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(187, 177);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(295, 32);
            this.txtJMBG.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(187, 122);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(295, 32);
            this.txtPrezime.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "JMBG";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(187, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(295, 32);
            this.txtIme.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Datum rođenja";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adresa";
            // 
            // gbDetaljiOKorisniku
            // 
            this.gbDetaljiOKorisniku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDetaljiOKorisniku.Controls.Add(this.txtAdresa);
            this.gbDetaljiOKorisniku.Controls.Add(this.dtpDatumRodjenja);
            this.gbDetaljiOKorisniku.Controls.Add(this.label8);
            this.gbDetaljiOKorisniku.Controls.Add(this.label7);
            this.gbDetaljiOKorisniku.Controls.Add(this.label4);
            this.gbDetaljiOKorisniku.Controls.Add(this.txtIme);
            this.gbDetaljiOKorisniku.Controls.Add(this.txtJMBG);
            this.gbDetaljiOKorisniku.Controls.Add(this.label6);
            this.gbDetaljiOKorisniku.Controls.Add(this.label5);
            this.gbDetaljiOKorisniku.Controls.Add(this.txtPrezime);
            this.gbDetaljiOKorisniku.ForeColor = System.Drawing.Color.White;
            this.gbDetaljiOKorisniku.Location = new System.Drawing.Point(598, 82);
            this.gbDetaljiOKorisniku.Name = "gbDetaljiOKorisniku";
            this.gbDetaljiOKorisniku.Size = new System.Drawing.Size(513, 372);
            this.gbDetaljiOKorisniku.TabIndex = 21;
            this.gbDetaljiOKorisniku.TabStop = false;
            this.gbDetaljiOKorisniku.Text = "Detalji o korisniku";
            // 
            // UCKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gbDetaljiOKorisniku);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnSviKorisnici);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCKorisnici";
            this.Size = new System.Drawing.Size(1145, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.gbDetaljiOKorisniku.ResumeLayout(false);
            this.gbDetaljiOKorisniku.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button btnSviKorisnici;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbDetaljiOKorisniku;
    }
}
