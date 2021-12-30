namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnZaustaviServer = new System.Windows.Forms.Button();
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(196, 362);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(312, 32);
            this.txtStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZaustaviServer.BackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.BackgroundImage = global::Server.Properties.Resources.red_button1;
            this.btnZaustaviServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZaustaviServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZaustaviServer.FlatAppearance.BorderSize = 0;
            this.btnZaustaviServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaustaviServer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustaviServer.Location = new System.Drawing.Point(432, 268);
            this.btnZaustaviServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(196, 62);
            this.btnZaustaviServer.TabIndex = 8;
            this.btnZaustaviServer.Text = "Zaustavi server";
            this.btnZaustaviServer.UseVisualStyleBackColor = false;
            this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreniServer.BackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.BackgroundImage = global::Server.Properties.Resources.red_button1;
            this.btnPokreniServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPokreniServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPokreniServer.FlatAppearance.BorderSize = 0;
            this.btnPokreniServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreniServer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreniServer.Location = new System.Drawing.Point(54, 268);
            this.btnPokreniServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(196, 62);
            this.btnPokreniServer.TabIndex = 9;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = false;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.gym;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(682, 452);
            this.Controls.Add(this.btnPokreniServer);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnZaustaviServer;
        private System.Windows.Forms.Button btnPokreniServer;
    }
}

