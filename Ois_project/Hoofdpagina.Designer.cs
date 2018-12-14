namespace Ois_project
{
    partial class Inlogform
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
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnJeugd = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrainer
            // 
            this.btnTrainer.Location = new System.Drawing.Point(40, 293);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(153, 70);
            this.btnTrainer.TabIndex = 0;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = true;
            // 
            // btnJeugd
            // 
            this.btnJeugd.Location = new System.Drawing.Point(544, 293);
            this.btnJeugd.Name = "btnJeugd";
            this.btnJeugd.Size = new System.Drawing.Size(157, 70);
            this.btnJeugd.TabIndex = 1;
            this.btnJeugd.Text = "Jeugd";
            this.btnJeugd.UseVisualStyleBackColor = true;
            this.btnJeugd.Click += new System.EventHandler(this.btnJeugd_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(300, 293);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(163, 70);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Inlogform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ois_project.Properties.Resources.Archieffoto_Omroep_West;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 482);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnJeugd);
            this.Controls.Add(this.btnTrainer);
            this.Name = "Inlogform";
            this.Text = "inlog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnJeugd;
        private System.Windows.Forms.Button btnAdmin;
    }
}

