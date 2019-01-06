namespace Ois_project
{
    partial class jeugd
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
            this.lblGbnaam = new System.Windows.Forms.Label();
            this.lblWw = new System.Windows.Forms.Label();
            this.lblRegistreer = new System.Windows.Forms.Label();
            this.btnInlog = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.tbGbNaam = new System.Windows.Forms.TextBox();
            this.tbWw = new System.Windows.Forms.TextBox();
            this.Tekenbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tekenbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGbnaam
            // 
            this.lblGbnaam.AutoSize = true;
            this.lblGbnaam.Location = new System.Drawing.Point(13, 70);
            this.lblGbnaam.Name = "lblGbnaam";
            this.lblGbnaam.Size = new System.Drawing.Size(87, 13);
            this.lblGbnaam.TabIndex = 0;
            this.lblGbnaam.Text = "Gebruikersnaam:";
            // 
            // lblWw
            // 
            this.lblWw.AutoSize = true;
            this.lblWw.Location = new System.Drawing.Point(13, 122);
            this.lblWw.Name = "lblWw";
            this.lblWw.Size = new System.Drawing.Size(71, 13);
            this.lblWw.TabIndex = 1;
            this.lblWw.Text = "Wachtwoord:";
            // 
            // lblRegistreer
            // 
            this.lblRegistreer.AutoSize = true;
            this.lblRegistreer.Location = new System.Drawing.Point(13, 217);
            this.lblRegistreer.Name = "lblRegistreer";
            this.lblRegistreer.Size = new System.Drawing.Size(127, 13);
            this.lblRegistreer.TabIndex = 2;
            this.lblRegistreer.Text = "Geen account? registreer";
            // 
            // btnInlog
            // 
            this.btnInlog.Location = new System.Drawing.Point(181, 167);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(100, 23);
            this.btnInlog.TabIndex = 3;
            this.btnInlog.Text = "Inloggen";
            this.btnInlog.UseVisualStyleBackColor = true;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(181, 212);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(100, 23);
            this.btnRegistreer.TabIndex = 4;
            this.btnRegistreer.Text = "Registreren";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // tbGbNaam
            // 
            this.tbGbNaam.Location = new System.Drawing.Point(130, 67);
            this.tbGbNaam.Name = "tbGbNaam";
            this.tbGbNaam.Size = new System.Drawing.Size(151, 20);
            this.tbGbNaam.TabIndex = 5;
            // 
            // tbWw
            // 
            this.tbWw.Location = new System.Drawing.Point(130, 119);
            this.tbWw.Name = "tbWw";
            this.tbWw.Size = new System.Drawing.Size(151, 20);
            this.tbWw.TabIndex = 6;
            this.tbWw.UseSystemPasswordChar = true;
            // 
            // Tekenbox
            // 
            this.Tekenbox.Location = new System.Drawing.Point(303, 36);
            this.Tekenbox.Name = "Tekenbox";
            this.Tekenbox.Size = new System.Drawing.Size(148, 199);
            this.Tekenbox.TabIndex = 7;
            this.Tekenbox.TabStop = false;
            // 
            // jeugd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 264);
            this.Controls.Add(this.Tekenbox);
            this.Controls.Add(this.tbWw);
            this.Controls.Add(this.tbGbNaam);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.btnInlog);
            this.Controls.Add(this.lblRegistreer);
            this.Controls.Add(this.lblWw);
            this.Controls.Add(this.lblGbnaam);
            this.Name = "jeugd";
            this.Text = "jeugd";
            ((System.ComponentModel.ISupportInitialize)(this.Tekenbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGbnaam;
        private System.Windows.Forms.Label lblWw;
        private System.Windows.Forms.Label lblRegistreer;
        private System.Windows.Forms.Button btnInlog;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox tbGbNaam;
        private System.Windows.Forms.TextBox tbWw;
        private System.Windows.Forms.PictureBox Tekenbox;
    }
}