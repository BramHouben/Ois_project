﻿namespace Ois_project
{
    partial class Admin
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
            this.btntrainer_aanmaken = new System.Windows.Forms.Button();
            this.btnAccVerwijder = new System.Windows.Forms.Button();
            this.btngeefTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeamToevoegen
            // 
            this.btnTeamToevoegen.Location = new System.Drawing.Point(12, 12);
            this.btnTeamToevoegen.Name = "btnTeamToevoegen";
            this.btnTeamToevoegen.Size = new System.Drawing.Size(114, 47);
            this.btnTeamToevoegen.TabIndex = 0;
            this.btnTeamToevoegen.Text = "Team toevoegen";
            this.btnTeamToevoegen.UseVisualStyleBackColor = true;
            this.btnTeamToevoegen.Click += new System.EventHandler(this.btnTeamToevoegen_Click);
            // 
            // btntrainer_aanmaken
            // 
            this.btntrainer_aanmaken.Location = new System.Drawing.Point(161, 12);
            this.btntrainer_aanmaken.Name = "btntrainer_aanmaken";
            this.btntrainer_aanmaken.Size = new System.Drawing.Size(143, 46);
            this.btntrainer_aanmaken.TabIndex = 1;
            this.btntrainer_aanmaken.Text = "Trainer toevoegen";
            this.btntrainer_aanmaken.UseVisualStyleBackColor = true;
            this.btntrainer_aanmaken.Click += new System.EventHandler(this.btntrainer_aanmaken_Click);
            // 
            // btnAccVerwijder
            // 
            this.btnAccVerwijder.Location = new System.Drawing.Point(321, 13);
            this.btnAccVerwijder.Name = "btnAccVerwijder";
            this.btnAccVerwijder.Size = new System.Drawing.Size(138, 45);
            this.btnAccVerwijder.TabIndex = 2;
            this.btnAccVerwijder.Text = "Account verwijderen";
            this.btnAccVerwijder.UseVisualStyleBackColor = true;
            this.btnAccVerwijder.Click += new System.EventHandler(this.btnAccVerwijder_Click);
            // 
            // btngeefTeam
            // 
            this.btngeefTeam.Location = new System.Drawing.Point(495, 13);
            this.btngeefTeam.Name = "btngeefTeam";
            this.btngeefTeam.Size = new System.Drawing.Size(147, 45);
            this.btngeefTeam.TabIndex = 3;
            this.btngeefTeam.Text = "Team geven aan speler";
            this.btngeefTeam.UseVisualStyleBackColor = true;
            this.btngeefTeam.Click += new System.EventHandler(this.btngeefTeam_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 65);
            this.Controls.Add(this.btngeefTeam);
            this.Controls.Add(this.btnAccVerwijder);
            this.Controls.Add(this.btntrainer_aanmaken);
            this.Controls.Add(this.btnTeamToevoegen);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeamToevoegen;
        private System.Windows.Forms.Button btntrainer_aanmaken;
        private System.Windows.Forms.Button btnAccVerwijder;
        private System.Windows.Forms.Button btngeefTeam;
    }
}