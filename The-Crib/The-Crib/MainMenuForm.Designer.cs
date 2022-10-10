namespace The_Crib
{
    partial class MainMenuForm
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
            this.StartGameBT = new System.Windows.Forms.Button();
            this.CreditsBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTextLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameBT
            // 
            this.StartGameBT.BackColor = System.Drawing.Color.CadetBlue;
            this.StartGameBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameBT.FlatAppearance.BorderSize = 0;
            this.StartGameBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartGameBT.Location = new System.Drawing.Point(68, 370);
            this.StartGameBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartGameBT.Name = "StartGameBT";
            this.StartGameBT.Size = new System.Drawing.Size(413, 111);
            this.StartGameBT.TabIndex = 0;
            this.StartGameBT.Text = "Start game";
            this.StartGameBT.UseVisualStyleBackColor = false;
            this.StartGameBT.Click += new System.EventHandler(this.StartGameBT_Click);
            // 
            // CreditsBT
            // 
            this.CreditsBT.BackColor = System.Drawing.Color.CadetBlue;
            this.CreditsBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditsBT.FlatAppearance.BorderSize = 0;
            this.CreditsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreditsBT.Location = new System.Drawing.Point(68, 554);
            this.CreditsBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditsBT.Name = "CreditsBT";
            this.CreditsBT.Size = new System.Drawing.Size(413, 111);
            this.CreditsBT.TabIndex = 1;
            this.CreditsBT.Text = "Credits";
            this.CreditsBT.UseVisualStyleBackColor = false;
            this.CreditsBT.Click += new System.EventHandler(this.CreditsBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::The_Crib.Properties.Resources.semi_transparent_background;
            this.panel1.Controls.Add(this.nameTextLB);
            this.panel1.Controls.Add(this.StartGameBT);
            this.panel1.Controls.Add(this.CreditsBT);
            this.panel1.Location = new System.Drawing.Point(1199, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 961);
            this.panel1.TabIndex = 2;
            // 
            // nameTextLB
            // 
            this.nameTextLB.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextLB.ForeColor = System.Drawing.Color.CadetBlue;
            this.nameTextLB.Location = new System.Drawing.Point(68, 68);
            this.nameTextLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameTextLB.Name = "nameTextLB";
            this.nameTextLB.Size = new System.Drawing.Size(413, 202);
            this.nameTextLB.TabIndex = 2;
            this.nameTextLB.Text = "The\r\nCrib";
            this.nameTextLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::The_Crib.Properties.Resources.maapallo_owl;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(331, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 559);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::The_Crib.Properties.Resources.TUTORS_logo_nega_h40mm;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 948);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(385, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.Frontyard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartGameForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameBT;
        private System.Windows.Forms.Button CreditsBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameTextLB;
    }
}