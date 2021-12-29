namespace View.UserControls
{
    partial class UCTermini
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
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.dgvSveRezervacije = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Svi termini usluga";
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
            this.btnObrisiTermin.Location = new System.Drawing.Point(882, 548);
            this.btnObrisiTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(207, 43);
            this.btnObrisiTermin.TabIndex = 13;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            // 
            // dgvSveRezervacije
            // 
            this.dgvSveRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSveRezervacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvSveRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveRezervacije.Location = new System.Drawing.Point(51, 96);
            this.dgvSveRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSveRezervacije.Name = "dgvSveRezervacije";
            this.dgvSveRezervacije.RowHeadersWidth = 51;
            this.dgvSveRezervacije.RowTemplate.Height = 24;
            this.dgvSveRezervacije.Size = new System.Drawing.Size(1038, 428);
            this.dgvSveRezervacije.TabIndex = 12;
            // 
            // UCTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.dgvSveRezervacije);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCTermini";
            this.Size = new System.Drawing.Size(1145, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.DataGridView dgvSveRezervacije;
    }
}
