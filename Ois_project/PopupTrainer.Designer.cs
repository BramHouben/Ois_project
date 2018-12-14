namespace Ois_project
{
    partial class PopupTrainer
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
            this.btnTeamToevoegen = new System.Windows.Forms.Button();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblTrainernaam = new System.Windows.Forms.Label();
            this.tbTtrainerNaam = new System.Windows.Forms.TextBox();
            this.NUD_leeftijd = new System.Windows.Forms.NumericUpDown();
            this.LBTeamSelect = new System.Windows.Forms.ListBox();
            this.lblTeamselect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_leeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeamToevoegen
            // 
            this.btnTeamToevoegen.Location = new System.Drawing.Point(129, 168);
            this.btnTeamToevoegen.Name = "btnTeamToevoegen";
            this.btnTeamToevoegen.Size = new System.Drawing.Size(90, 23);
            this.btnTeamToevoegen.TabIndex = 9;
            this.btnTeamToevoegen.Text = "Toevoegen";
            this.btnTeamToevoegen.UseVisualStyleBackColor = true;
            this.btnTeamToevoegen.Click += new System.EventHandler(this.btnTeamToevoegen_Click);
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(223, 56);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(44, 13);
            this.lblLeeftijd.TabIndex = 7;
            this.lblLeeftijd.Text = "Leeftijd:";
            // 
            // lblTrainernaam
            // 
            this.lblTrainernaam.AutoSize = true;
            this.lblTrainernaam.Location = new System.Drawing.Point(54, 56);
            this.lblTrainernaam.Name = "lblTrainernaam";
            this.lblTrainernaam.Size = new System.Drawing.Size(72, 13);
            this.lblTrainernaam.TabIndex = 6;
            this.lblTrainernaam.Text = "Trainer naam:";
            // 
            // tbTtrainerNaam
            // 
            this.tbTtrainerNaam.Location = new System.Drawing.Point(57, 102);
            this.tbTtrainerNaam.Name = "tbTtrainerNaam";
            this.tbTtrainerNaam.Size = new System.Drawing.Size(92, 20);
            this.tbTtrainerNaam.TabIndex = 5;
            // 
            // NUD_leeftijd
            // 
            this.NUD_leeftijd.Location = new System.Drawing.Point(226, 101);
            this.NUD_leeftijd.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.NUD_leeftijd.Name = "NUD_leeftijd";
            this.NUD_leeftijd.Size = new System.Drawing.Size(62, 20);
            this.NUD_leeftijd.TabIndex = 10;
            this.NUD_leeftijd.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // LBTeamSelect
            // 
            this.LBTeamSelect.FormattingEnabled = true;
            this.LBTeamSelect.Location = new System.Drawing.Point(345, 96);
            this.LBTeamSelect.Name = "LBTeamSelect";
            this.LBTeamSelect.Size = new System.Drawing.Size(120, 95);
            this.LBTeamSelect.TabIndex = 11;
            // 
            // lblTeamselect
            // 
            this.lblTeamselect.AutoSize = true;
            this.lblTeamselect.Location = new System.Drawing.Point(345, 55);
            this.lblTeamselect.Name = "lblTeamselect";
            this.lblTeamselect.Size = new System.Drawing.Size(30, 13);
            this.lblTeamselect.TabIndex = 12;
            this.lblTeamselect.Text = "team";
            // 
            // PopupTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.lblTeamselect);
            this.Controls.Add(this.LBTeamSelect);
            this.Controls.Add(this.NUD_leeftijd);
            this.Controls.Add(this.btnTeamToevoegen);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblTrainernaam);
            this.Controls.Add(this.tbTtrainerNaam);
            this.Name = "PopupTrainer";
            this.Text = "PopupTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_leeftijd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeamToevoegen;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblTrainernaam;
        private System.Windows.Forms.TextBox tbTtrainerNaam;
        private System.Windows.Forms.NumericUpDown NUD_leeftijd;
        private System.Windows.Forms.ListBox LBTeamSelect;
        private System.Windows.Forms.Label lblTeamselect;
    }
}