namespace The_Crib
{
    partial class CreditsForm
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
            this.CreditsLB = new System.Windows.Forms.Label();
            this.ProgrammingLB = new System.Windows.Forms.Label();
            this.GraphicsLB = new System.Windows.Forms.Label();
            this.ProgrammerNamesLB = new System.Windows.Forms.Label();
            this.GraphicsNamesLB = new System.Windows.Forms.Label();
            this.TutorsLogoPB = new System.Windows.Forms.PictureBox();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TutorsLogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditsLB
            // 
            this.CreditsLB.AutoSize = true;
            this.CreditsLB.BackColor = System.Drawing.Color.Transparent;
            this.CreditsLB.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLB.ForeColor = System.Drawing.Color.White;
            this.CreditsLB.Location = new System.Drawing.Point(684, 9);
            this.CreditsLB.Name = "CreditsLB";
            this.CreditsLB.Size = new System.Drawing.Size(272, 74);
            this.CreditsLB.TabIndex = 0;
            this.CreditsLB.Text = "Credits";
            // 
            // ProgrammingLB
            // 
            this.ProgrammingLB.AutoSize = true;
            this.ProgrammingLB.BackColor = System.Drawing.Color.Transparent;
            this.ProgrammingLB.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammingLB.ForeColor = System.Drawing.Color.White;
            this.ProgrammingLB.Location = new System.Drawing.Point(403, 188);
            this.ProgrammingLB.Name = "ProgrammingLB";
            this.ProgrammingLB.Size = new System.Drawing.Size(263, 40);
            this.ProgrammingLB.TabIndex = 1;
            this.ProgrammingLB.Text = "Programming";
            // 
            // GraphicsLB
            // 
            this.GraphicsLB.AutoSize = true;
            this.GraphicsLB.BackColor = System.Drawing.Color.Transparent;
            this.GraphicsLB.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsLB.ForeColor = System.Drawing.Color.White;
            this.GraphicsLB.Location = new System.Drawing.Point(1053, 188);
            this.GraphicsLB.Name = "GraphicsLB";
            this.GraphicsLB.Size = new System.Drawing.Size(178, 40);
            this.GraphicsLB.TabIndex = 2;
            this.GraphicsLB.Text = "Graphics";
            // 
            // ProgrammerNamesLB
            // 
            this.ProgrammerNamesLB.AutoSize = true;
            this.ProgrammerNamesLB.BackColor = System.Drawing.Color.Transparent;
            this.ProgrammerNamesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerNamesLB.ForeColor = System.Drawing.Color.White;
            this.ProgrammerNamesLB.Location = new System.Drawing.Point(491, 237);
            this.ProgrammerNamesLB.Name = "ProgrammerNamesLB";
            this.ProgrammerNamesLB.Size = new System.Drawing.Size(86, 155);
            this.ProgrammerNamesLB.TabIndex = 5;
            this.ProgrammerNamesLB.Text = "Name\r\nName\r\nName\r\nName\r\n\r\n";
            // 
            // GraphicsNamesLB
            // 
            this.GraphicsNamesLB.AutoSize = true;
            this.GraphicsNamesLB.BackColor = System.Drawing.Color.Transparent;
            this.GraphicsNamesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsNamesLB.ForeColor = System.Drawing.Color.White;
            this.GraphicsNamesLB.Location = new System.Drawing.Point(1099, 237);
            this.GraphicsNamesLB.Name = "GraphicsNamesLB";
            this.GraphicsNamesLB.Size = new System.Drawing.Size(86, 124);
            this.GraphicsNamesLB.TabIndex = 6;
            this.GraphicsNamesLB.Text = "Name\r\nName\r\nName\r\nName\r\n";
            // 
            // TutorsLogoPB
            // 
            this.TutorsLogoPB.BackColor = System.Drawing.Color.Transparent;
            this.TutorsLogoPB.BackgroundImage = global::The_Crib.Properties.Resources.TUTORS_logo_nega_h40mm;
            this.TutorsLogoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TutorsLogoPB.Location = new System.Drawing.Point(12, 798);
            this.TutorsLogoPB.Name = "TutorsLogoPB";
            this.TutorsLogoPB.Size = new System.Drawing.Size(289, 81);
            this.TutorsLogoPB.TabIndex = 8;
            this.TutorsLogoPB.TabStop = false;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(12, 9);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(91, 43);
            this.MainMenuBtn.TabIndex = 9;
            this.MainMenuBtn.Text = "Main menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.Frontyard;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.TutorsLogoPB);
            this.Controls.Add(this.GraphicsNamesLB);
            this.Controls.Add(this.ProgrammerNamesLB);
            this.Controls.Add(this.GraphicsLB);
            this.Controls.Add(this.ProgrammingLB);
            this.Controls.Add(this.CreditsLB);
            this.Name = "CreditsForm";
            this.Text = "CreditsForm";
            this.Load += new System.EventHandler(this.CreditsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TutorsLogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditsLB;
        private System.Windows.Forms.Label ProgrammingLB;
        private System.Windows.Forms.Label GraphicsLB;
        private System.Windows.Forms.Label ProgrammerNamesLB;
        private System.Windows.Forms.Label GraphicsNamesLB;
        private System.Windows.Forms.PictureBox TutorsLogoPB;
        private System.Windows.Forms.Button MainMenuBtn;
    }
}