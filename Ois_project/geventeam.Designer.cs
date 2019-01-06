namespace Ois_project
{
    partial class geventeam
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
            this.lbSpeler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbteam = new System.Windows.Forms.ListBox();
            this.btnGevenTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSpeler
            // 
            this.lbSpeler.FormattingEnabled = true;
            this.lbSpeler.Location = new System.Drawing.Point(55, 101);
            this.lbSpeler.Name = "lbSpeler";
            this.lbSpeler.Size = new System.Drawing.Size(95, 121);
            this.lbSpeler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leden zonder team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team:";
            // 
            // lbteam
            // 
            this.lbteam.FormattingEnabled = true;
            this.lbteam.Location = new System.Drawing.Point(234, 101);
            this.lbteam.Name = "lbteam";
            this.lbteam.Size = new System.Drawing.Size(89, 121);
            this.lbteam.TabIndex = 3;
            // 
            // btnGevenTeam
            // 
            this.btnGevenTeam.Location = new System.Drawing.Point(133, 228);
            this.btnGevenTeam.Name = "btnGevenTeam";
            this.btnGevenTeam.Size = new System.Drawing.Size(107, 23);
            this.btnGevenTeam.TabIndex = 4;
            this.btnGevenTeam.Text = "Geven team:";
            this.btnGevenTeam.UseVisualStyleBackColor = true;
            this.btnGevenTeam.Click += new System.EventHandler(this.btnGevenTeam_Click);
            // 
            // geventeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 289);
            this.Controls.Add(this.btnGevenTeam);
            this.Controls.Add(this.lbteam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSpeler);
            this.Name = "geventeam";
            this.Text = "geventeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbteam;
        private System.Windows.Forms.Button btnGevenTeam;
    }
}