namespace View.UserControls
{
    partial class UCUnosRezervacija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.cmbTermini = new System.Windows.Forms.ComboBox();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvajRezervacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AllowUserToResizeColumns = false;
            this.dgvRezervacije.AllowUserToResizeRows = false;
            this.dgvRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRezervacije.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(61, 197);
            this.dgvRezervacije.Name = "dgvRezervacije";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.Size = new System.Drawing.Size(940, 166);
            this.dgvRezervacije.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnObrisiRezervaciju);
            this.groupBox1.Controls.Add(this.btnDodajRezervaciju);
            this.groupBox1.Controls.Add(this.cmbTermini);
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Controls.Add(this.cmbKorisnici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 469);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesi novu rezervaciju";
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiRezervaciju.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnObrisiRezervaciju.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiRezervaciju.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnObrisiRezervaciju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiRezervaciju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(794, 394);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(207, 43);
            this.btnObrisiRezervaciju.TabIndex = 23;
            this.btnObrisiRezervaciju.Text = "Obriši rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajRezervaciju.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnDodajRezervaciju.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajRezervaciju.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDodajRezervaciju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(794, 117);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(207, 43);
            this.btnDodajRezervaciju.TabIndex = 20;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // cmbTermini
            // 
            this.cmbTermini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTermini.FormattingEnabled = true;
            this.cmbTermini.Location = new System.Drawing.Point(259, 123);
            this.cmbTermini.Name = "cmbTermini";
            this.cmbTermini.Size = new System.Drawing.Size(433, 32);
            this.cmbTermini.TabIndex = 22;
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(259, 65);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(433, 32);
            this.cmbKorisnici.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Korisnik:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Termin:";
            // 
            // btnSacuvajRezervacije
            // 
            this.btnSacuvajRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajRezervacije.BackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajRezervacije.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnSacuvajRezervacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSacuvajRezervacije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSacuvajRezervacije.FlatAppearance.BorderSize = 0;
            this.btnSacuvajRezervacije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajRezervacije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajRezervacije.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajRezervacije.Location = new System.Drawing.Point(896, 548);
            this.btnSacuvajRezervacije.Name = "btnSacuvajRezervacije";
            this.btnSacuvajRezervacije.Size = new System.Drawing.Size(207, 43);
            this.btnSacuvajRezervacije.TabIndex = 24;
            this.btnSacuvajRezervacije.Text = "Sačuvaj rezervacije";
            this.btnSacuvajRezervacije.UseVisualStyleBackColor = false;
            this.btnSacuvajRezervacije.Click += new System.EventHandler(this.btnSacuvajRezervacije_Click);
            // 
            // UCUnosRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSacuvajRezervacije);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUnosRezervacija";
            this.Size = new System.Drawing.Size(1145, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.ComboBox cmbTermini;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnSacuvajRezervacije;
    }
}
