namespace Ois_project
{
    partial class PopupTeam
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
            this.tbTeam = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamAantal = new System.Windows.Forms.Label();
            this.tbTeam_aantal = new System.Windows.Forms.TextBox();
            this.btnTeamToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTeam
            // 
            this.tbTeam.Location = new System.Drawing.Point(41, 83);
            this.tbTeam.Name = "tbTeam";
            this.tbTeam.Size = new System.Drawing.Size(63, 20);
            this.tbTeam.TabIndex = 0;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(38, 37);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(66, 13);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team naam:";
            // 
            // lblTeamAantal
            // 
            this.lblTeamAantal.AutoSize = true;
            this.lblTeamAantal.Location = new System.Drawing.Point(207, 37);
            this.lblTeamAantal.Name = "lblTeamAantal";
            this.lblTeamAantal.Size = new System.Drawing.Size(40, 13);
            this.lblTeamAantal.TabIndex = 2;
            this.lblTeamAantal.Text = "Aantal:";
            // 
            // tbTeam_aantal
            // 
            this.tbTeam_aantal.Location = new System.Drawing.Point(210, 83);
            this.tbTeam_aantal.Name = "tbTeam_aantal";
            this.tbTeam_aantal.Size = new System.Drawing.Size(100, 20);
            this.tbTeam_aantal.TabIndex = 3;
            // 
            // btnTeamToevoegen
            // 
            this.btnTeamToevoegen.Location = new System.Drawing.Point(113, 149);
            this.btnTeamToevoegen.Name = "btnTeamToevoegen";
            this.btnTeamToevoegen.Size = new System.Drawing.Size(90, 23);
            this.btnTeamToevoegen.TabIndex = 4;
            this.btnTeamToevoegen.Text = "Toevoegen";
            this.btnTeamToevoegen.UseVisualStyleBackColor = true;
            this.btnTeamToevoegen.Click += new System.EventHandler(this.btnTeamToevoegen_Click);
            // 
            // PopupTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 219);
            this.Controls.Add(this.btnTeamToevoegen);
            this.Controls.Add(this.tbTeam_aantal);
            this.Controls.Add(this.lblTeamAantal);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.tbTeam);
            this.Name = "PopupTeam";
            this.Text = "PopupTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTeam;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamAantal;
        private System.Windows.Forms.TextBox tbTeam_aantal;
        private System.Windows.Forms.Button btnTeamToevoegen;
    }
}