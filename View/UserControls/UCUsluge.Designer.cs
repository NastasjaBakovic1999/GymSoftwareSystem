namespace View.UserControls
{
    partial class UCUsluge
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.gbUnosUsluge = new System.Windows.Forms.GroupBox();
            this.btnSacuvajUslugu = new System.Windows.Forms.Button();
            this.cmbTrener = new System.Windows.Forms.ComboBox();
            this.txtNazivUsluge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.gbUnosUsluge.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usluge";
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.AllowUserToResizeColumns = false;
            this.dgvUsluge.AllowUserToResizeRows = false;
            this.dgvUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsluge.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(30, 104);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(512, 433);
            this.dgvUsluge.TabIndex = 1;
            // 
            // gbUnosUsluge
            // 
            this.gbUnosUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUnosUsluge.Controls.Add(this.btnSacuvajUslugu);
            this.gbUnosUsluge.Controls.Add(this.cmbTrener);
            this.gbUnosUsluge.Controls.Add(this.txtNazivUsluge);
            this.gbUnosUsluge.Controls.Add(this.label3);
            this.gbUnosUsluge.Controls.Add(this.label2);
            this.gbUnosUsluge.ForeColor = System.Drawing.Color.White;
            this.gbUnosUsluge.Location = new System.Drawing.Point(582, 95);
            this.gbUnosUsluge.Name = "gbUnosUsluge";
            this.gbUnosUsluge.Size = new System.Drawing.Size(541, 386);
            this.gbUnosUsluge.TabIndex = 3;
            this.gbUnosUsluge.TabStop = false;
            this.gbUnosUsluge.Text = "Unos nove usluge";
            // 
            // btnSacuvajUslugu
            // 
            this.btnSacuvajUslugu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajUslugu.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnSacuvajUslugu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSacuvajUslugu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSacuvajUslugu.FlatAppearance.BorderSize = 0;
            this.btnSacuvajUslugu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajUslugu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSacuvajUslugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajUslugu.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajUslugu.Location = new System.Drawing.Point(309, 235);
            this.btnSacuvajUslugu.Name = "btnSacuvajUslugu";
            this.btnSacuvajUslugu.Size = new System.Drawing.Size(207, 43);
            this.btnSacuvajUslugu.TabIndex = 4;
            this.btnSacuvajUslugu.Text = "Sačuvaj uslugu";
            this.btnSacuvajUslugu.UseVisualStyleBackColor = true;
            this.btnSacuvajUslugu.Click += new System.EventHandler(this.btnSacuvajUslugu_Click);
            // 
            // cmbTrener
            // 
            this.cmbTrener.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTrener.FormattingEnabled = true;
            this.cmbTrener.Location = new System.Drawing.Point(206, 173);
            this.cmbTrener.Name = "cmbTrener";
            this.cmbTrener.Size = new System.Drawing.Size(310, 32);
            this.cmbTrener.TabIndex = 3;
            // 
            // txtNazivUsluge
            // 
            this.txtNazivUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivUsluge.Location = new System.Drawing.Point(186, 111);
            this.txtNazivUsluge.Name = "txtNazivUsluge";
            this.txtNazivUsluge.Size = new System.Drawing.Size(330, 32);
            this.txtNazivUsluge.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trener:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv usluge:";
            // 
            // btnObrisiUslugu
            // 
            this.btnObrisiUslugu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiUslugu.BackgroundImage = global::View.Properties.Resources.red_button1;
            this.btnObrisiUslugu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiUslugu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiUslugu.FlatAppearance.BorderSize = 0;
            this.btnObrisiUslugu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiUslugu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnObrisiUslugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiUslugu.ForeColor = System.Drawing.Color.White;
            this.btnObrisiUslugu.Location = new System.Drawing.Point(582, 494);
            this.btnObrisiUslugu.Name = "btnObrisiUslugu";
            this.btnObrisiUslugu.Size = new System.Drawing.Size(207, 43);
            this.btnObrisiUslugu.TabIndex = 2;
            this.btnObrisiUslugu.Text = "Obriši uslugu";
            this.btnObrisiUslugu.UseVisualStyleBackColor = true;
            this.btnObrisiUslugu.Click += new System.EventHandler(this.btnObrisiUslugu_Click);
            // 
            // UCUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gbUnosUsluge);
            this.Controls.Add(this.btnObrisiUslugu);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUsluge";
            this.Size = new System.Drawing.Size(1145, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.gbUnosUsluge.ResumeLayout(false);
            this.gbUnosUsluge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.GroupBox gbUnosUsluge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvajUslugu;
        private System.Windows.Forms.ComboBox cmbTrener;
        private System.Windows.Forms.TextBox txtNazivUsluge;
    }
}
