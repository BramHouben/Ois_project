namespace Ois_project
{
    partial class Registratie
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
            this.tbWw = new System.Windows.Forms.TextBox();
            this.tbGbNaam = new System.Windows.Forms.TextBox();
            this.btnRegistratie = new System.Windows.Forms.Button();
            this.lblWw = new System.Windows.Forms.Label();
            this.lblGbnaam = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbWw
            // 
            this.tbWw.Location = new System.Drawing.Point(111, 82);
            this.tbWw.Name = "tbWw";
            this.tbWw.Size = new System.Drawing.Size(100, 20);
            this.tbWw.TabIndex = 11;
            this.tbWw.UseSystemPasswordChar = true;
            // 
            // tbGbNaam
            // 
            this.tbGbNaam.Location = new System.Drawing.Point(111, 30);
            this.tbGbNaam.Name = "tbGbNaam";
            this.tbGbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbGbNaam.TabIndex = 10;
            // 
            // btnRegistratie
            // 
            this.btnRegistratie.Location = new System.Drawing.Point(111, 166);
            this.btnRegistratie.Name = "btnRegistratie";
            this.btnRegistratie.Size = new System.Drawing.Size(100, 23);
            this.btnRegistratie.TabIndex = 9;
            this.btnRegistratie.Text = "Registreren";
            this.btnRegistratie.UseVisualStyleBackColor = true;
            this.btnRegistratie.Click += new System.EventHandler(this.btnRegistratie_Click);
            // 
            // lblWw
            // 
            this.lblWw.AutoSize = true;
            this.lblWw.Location = new System.Drawing.Point(18, 82);
            this.lblWw.Name = "lblWw";
            this.lblWw.Size = new System.Drawing.Size(71, 13);
            this.lblWw.TabIndex = 8;
            this.lblWw.Text = "Wachtwoord:";
            // 
            // lblGbnaam
            // 
            this.lblGbnaam.AutoSize = true;
            this.lblGbnaam.Location = new System.Drawing.Point(18, 30);
            this.lblGbnaam.Name = "lblGbnaam";
            this.lblGbnaam.Size = new System.Drawing.Size(35, 13);
            this.lblGbnaam.TabIndex = 7;
            this.lblGbnaam.Text = "Email:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(21, 117);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 12;
            this.lblNaam.Text = "Naam:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(111, 117);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 13;
            // 
            // Registratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 217);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbWw);
            this.Controls.Add(this.tbGbNaam);
            this.Controls.Add(this.btnRegistratie);
            this.Controls.Add(this.lblWw);
            this.Controls.Add(this.lblGbnaam);
            this.Name = "Registratie";
            this.Text = "Registratie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWw;
        private System.Windows.Forms.TextBox tbGbNaam;
        private System.Windows.Forms.Button btnRegistratie;
        private System.Windows.Forms.Label lblWw;
        private System.Windows.Forms.Label lblGbnaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbNaam;
    }
}