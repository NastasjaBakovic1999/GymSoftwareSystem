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
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnZaustaviServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(188, 351);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(291, 23);
            this.txtStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreniServer.BackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.BackgroundImage = global::Server.Properties.Resources.button_red;
            this.btnPokreniServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPokreniServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPokreniServer.FlatAppearance.BorderSize = 0;
            this.btnPokreniServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPokreniServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreniServer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreniServer.Location = new System.Drawing.Point(97, 212);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(209, 83);
            this.btnPokreniServer.TabIndex = 4;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = false;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZaustaviServer.BackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.BackgroundImage = global::Server.Properties.Resources.button_red;
            this.btnZaustaviServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZaustaviServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZaustaviServer.FlatAppearance.BorderSize = 0;
            this.btnZaustaviServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZaustaviServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaustaviServer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustaviServer.Location = new System.Drawing.Point(370, 212);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(209, 83);
            this.btnZaustaviServer.TabIndex = 8;
            this.btnZaustaviServer.Text = "Zaustavi server";
            this.btnZaustaviServer.UseVisualStyleBackColor = false;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.gym;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(677, 451);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPokreniServer);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPokreniServer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnZaustaviServer;
    }
}

