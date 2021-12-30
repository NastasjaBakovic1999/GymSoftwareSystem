namespace View.UserControls
{
    partial class UCUnosTermina
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
            this.gbUnosKorisnika = new System.Windows.Forms.GroupBox();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.nudKapacitet = new System.Windows.Forms.NumericUpDown();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.cmbUsluge = new System.Windows.Forms.ComboBox();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSacuvajTermine = new System.Windows.Forms.Button();
            this.dtpVreme = new System.Windows.Forms.DateTimePicker();
            this.gbUnosKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUnosKorisnika
            // 
            this.gbUnosKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUnosKorisnika.Controls.Add(this.dtpVreme);
            this.gbUnosKorisnika.Controls.Add(this.btnObrisiTermin);
            this.gbUnosKorisnika.Controls.Add(this.label3);
            this.gbUnosKorisnika.Controls.Add(this.dgvTermini);
            this.gbUnosKorisnika.Controls.Add(this.nudKapacitet);
            this.gbUnosKorisnika.Controls.Add(this.dtpDatum);
            this.gbUnosKorisnika.Controls.Add(this.cmbSale);
            this.gbUnosKorisnika.Controls.Add(this.cmbUsluge);
            this.gbUnosKorisnika.Controls.Add(this.btnDodajTermin);
            this.gbUnosKorisnika.Controls.Add(this.label2);
            this.gbUnosKorisnika.Controls.Add(this.label7);
            this.gbUnosKorisnika.Controls.Add(this.label6);
            this.gbUnosKorisnika.Controls.Add(this.label4);
            this.gbUnosKorisnika.ForeColor = System.Drawing.Color.White;
            this.gbUnosKorisnika.Location = new System.Drawing.Point(61, 25);
            this.gbUnosKorisnika.Name = "gbUnosKorisnika";
            this.gbUnosKorisnika.Size = new System.Drawing.Size(1019, 527);
            this.gbUnosKorisnika.TabIndex = 16;
            this.gbUnosKorisnika.TabStop = false;
            this.gbUnosKorisnika.Text = "Unos novog termina";
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiTermin.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiTermin.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnObrisiTermin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiTermin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiTermin.FlatAppearance.BorderSize = 0;
            this.btnObrisiTermin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiTermin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiTermin.ForeColor = System.Drawing.Color.White;
            this.btnObrisiTermin.Location = new System.Drawing.Point(768, 446);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(207, 43);
            this.btnObrisiTermin.TabIndex = 14;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vreme:";
            // 
            // dgvTermini
            // 
            this.dgvTermini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.White;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(50, 261);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(925, 169);
            this.dgvTermini.TabIndex = 11;
            // 
            // nudKapacitet
            // 
            this.nudKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudKapacitet.Location = new System.Drawing.Point(353, 157);
            this.nudKapacitet.Name = "nudKapacitet";
            this.nudKapacitet.Size = new System.Drawing.Size(144, 32);
            this.nudKapacitet.TabIndex = 22;
            // 
            // dtpDatum
            // 
            this.dtpDatum.AllowDrop = true;
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(719, 46);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(256, 32);
            this.dtpDatum.TabIndex = 20;
            // 
            // cmbSale
            // 
            this.cmbSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(241, 49);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(256, 32);
            this.cmbSale.TabIndex = 19;
            // 
            // cmbUsluge
            // 
            this.cmbUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUsluge.FormattingEnabled = true;
            this.cmbUsluge.Location = new System.Drawing.Point(241, 106);
            this.cmbUsluge.Name = "cmbUsluge";
            this.cmbUsluge.Size = new System.Drawing.Size(256, 32);
            this.cmbUsluge.TabIndex = 18;
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTermin.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajTermin.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnDodajTermin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajTermin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDodajTermin.FlatAppearance.BorderSize = 0;
            this.btnDodajTermin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDodajTermin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodajTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajTermin.ForeColor = System.Drawing.Color.White;
            this.btnDodajTermin.Location = new System.Drawing.Point(768, 199);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(207, 43);
            this.btnDodajTermin.TabIndex = 17;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odaberite uslugu:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kapacitet:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Odaberite salu:";
            // 
            // btnSacuvajTermine
            // 
            this.btnSacuvajTermine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajTermine.BackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajTermine.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnSacuvajTermine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSacuvajTermine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSacuvajTermine.FlatAppearance.BorderSize = 0;
            this.btnSacuvajTermine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajTermine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajTermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajTermine.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajTermine.Location = new System.Drawing.Point(873, 568);
            this.btnSacuvajTermine.Name = "btnSacuvajTermine";
            this.btnSacuvajTermine.Size = new System.Drawing.Size(207, 43);
            this.btnSacuvajTermine.TabIndex = 25;
            this.btnSacuvajTermine.Text = "Sačuvaj termine";
            this.btnSacuvajTermine.UseVisualStyleBackColor = false;
            // 
            // dtpVreme
            // 
            this.dtpVreme.AllowDrop = true;
            this.dtpVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVreme.Location = new System.Drawing.Point(829, 99);
            this.dtpVreme.Name = "dtpVreme";
            this.dtpVreme.Size = new System.Drawing.Size(146, 32);
            this.dtpVreme.TabIndex = 25;
            // 
            // UCUnosTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSacuvajTermine);
            this.Controls.Add(this.gbUnosKorisnika);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUnosTermina";
            this.Size = new System.Drawing.Size(1145, 631);
            this.gbUnosKorisnika.ResumeLayout(false);
            this.gbUnosKorisnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.GroupBox gbUnosKorisnika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.ComboBox cmbUsluge;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudKapacitet;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSacuvajTermine;
        private System.Windows.Forms.DateTimePicker dtpVreme;
    }
}
