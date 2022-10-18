namespace The_Crib
{
    partial class LowerCabinetForm
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
            this.PotPB = new System.Windows.Forms.PictureBox();
            this.PanPB = new System.Windows.Forms.PictureBox();
            this.BowlPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PotPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowlPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PotPB
            // 
            this.PotPB.BackColor = System.Drawing.Color.Transparent;
            this.PotPB.Image = global::The_Crib.Properties.Resources.Pot;
            this.PotPB.Location = new System.Drawing.Point(206, 408);
            this.PotPB.Name = "PotPB";
            this.PotPB.Size = new System.Drawing.Size(203, 143);
            this.PotPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PotPB.TabIndex = 0;
            this.PotPB.TabStop = false;
            this.PotPB.Click += new System.EventHandler(this.LowerCabinetImgPB);
            // 
            // PanPB
            // 
            this.PanPB.BackColor = System.Drawing.Color.Transparent;
            this.PanPB.Image = global::The_Crib.Properties.Resources.FryingPan;
            this.PanPB.Location = new System.Drawing.Point(283, 195);
            this.PanPB.Name = "PanPB";
            this.PanPB.Size = new System.Drawing.Size(257, 121);
            this.PanPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PanPB.TabIndex = 1;
            this.PanPB.TabStop = false;
            this.PanPB.Click += new System.EventHandler(this.LowerCabinetImgPB);
            // 
            // BowlPB
            // 
            this.BowlPB.BackColor = System.Drawing.Color.Transparent;
            this.BowlPB.Image = global::The_Crib.Properties.Resources.Bowl;
            this.BowlPB.Location = new System.Drawing.Point(440, 426);
            this.BowlPB.Name = "BowlPB";
            this.BowlPB.Size = new System.Drawing.Size(163, 112);
            this.BowlPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowlPB.TabIndex = 2;
            this.BowlPB.TabStop = false;
            this.BowlPB.Click += new System.EventHandler(this.LowerCabinetImgPB);
            // 
            // LowerCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.LowerCabinetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(683, 657);
            this.Controls.Add(this.BowlPB);
            this.Controls.Add(this.PanPB);
            this.Controls.Add(this.PotPB);
            this.Name = "LowerCabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LowerCabinetForm";
            this.Load += new System.EventHandler(this.LowerCabinetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PotPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowlPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PotPB;
        private System.Windows.Forms.PictureBox PanPB;
        private System.Windows.Forms.PictureBox BowlPB;
    }
}