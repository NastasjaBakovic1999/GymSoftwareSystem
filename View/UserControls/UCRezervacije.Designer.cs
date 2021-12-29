namespace View.UserControls
{
    partial class UCRezervacije
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
            this.dgvSveRezervacije = new System.Windows.Forms.DataGridView();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSveRezervacije
            // 
            this.dgvSveRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSveRezervacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvSveRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveRezervacije.Location = new System.Drawing.Point(47, 101);
            this.dgvSveRezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSveRezervacije.Name = "dgvSveRezervacije";
            this.dgvSveRezervacije.RowHeadersWidth = 51;
            this.dgvSveRezervacije.RowTemplate.Height = 24;
            this.dgvSveRezervacije.Size = new System.Drawing.Size(1038, 428);
            this.dgvSveRezervacije.TabIndex = 0;
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
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(878, 553);
            this.btnObrisiRezervaciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(207, 43);
            this.btnObrisiRezervaciju.TabIndex = 10;
            this.btnObrisiRezervaciju.Text = "Obriši rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sve rezervacije";
            // 
            // UCRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.dgvSveRezervacije);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCRezervacije";
            this.Size = new System.Drawing.Size(1145, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSveRezervacije;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Label label1;
    }
}
