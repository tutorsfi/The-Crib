namespace The_Crib
{
    partial class CabinetForm
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
            this.PlatePB = new System.Windows.Forms.PictureBox();
            this.GlassPB = new System.Windows.Forms.PictureBox();
            this.GlassTwoPB = new System.Windows.Forms.PictureBox();
            this.GlassThreePB = new System.Windows.Forms.PictureBox();
            this.MugPB = new System.Windows.Forms.PictureBox();
            this.MugTwoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassTwoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassThreePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MugPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MugTwoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PlatePB
            // 
            this.PlatePB.BackColor = System.Drawing.Color.Transparent;
            this.PlatePB.Image = global::The_Crib.Properties.Resources.plates;
            this.PlatePB.Location = new System.Drawing.Point(292, 209);
            this.PlatePB.Name = "PlatePB";
            this.PlatePB.Size = new System.Drawing.Size(100, 50);
            this.PlatePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlatePB.TabIndex = 0;
            this.PlatePB.TabStop = false;
            this.PlatePB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // GlassPB
            // 
            this.GlassPB.BackColor = System.Drawing.Color.Transparent;
            this.GlassPB.Image = global::The_Crib.Properties.Resources.Glass;
            this.GlassPB.Location = new System.Drawing.Point(115, 65);
            this.GlassPB.Name = "GlassPB";
            this.GlassPB.Size = new System.Drawing.Size(37, 66);
            this.GlassPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlassPB.TabIndex = 1;
            this.GlassPB.TabStop = false;
            this.GlassPB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // GlassTwoPB
            // 
            this.GlassTwoPB.BackColor = System.Drawing.Color.Transparent;
            this.GlassTwoPB.Image = global::The_Crib.Properties.Resources.Glass;
            this.GlassTwoPB.Location = new System.Drawing.Point(158, 65);
            this.GlassTwoPB.Name = "GlassTwoPB";
            this.GlassTwoPB.Size = new System.Drawing.Size(37, 66);
            this.GlassTwoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlassTwoPB.TabIndex = 2;
            this.GlassTwoPB.TabStop = false;
            this.GlassTwoPB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // GlassThreePB
            // 
            this.GlassThreePB.BackColor = System.Drawing.Color.Transparent;
            this.GlassThreePB.Image = global::The_Crib.Properties.Resources.Glass;
            this.GlassThreePB.Location = new System.Drawing.Point(201, 65);
            this.GlassThreePB.Name = "GlassThreePB";
            this.GlassThreePB.Size = new System.Drawing.Size(37, 66);
            this.GlassThreePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlassThreePB.TabIndex = 3;
            this.GlassThreePB.TabStop = false;
            this.GlassThreePB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // MugPB
            // 
            this.MugPB.BackColor = System.Drawing.Color.Transparent;
            this.MugPB.Image = global::The_Crib.Properties.Resources.Mug;
            this.MugPB.Location = new System.Drawing.Point(95, 205);
            this.MugPB.Name = "MugPB";
            this.MugPB.Size = new System.Drawing.Size(57, 50);
            this.MugPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MugPB.TabIndex = 4;
            this.MugPB.TabStop = false;
            this.MugPB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // MugTwoPB
            // 
            this.MugTwoPB.BackColor = System.Drawing.Color.Transparent;
            this.MugTwoPB.Image = global::The_Crib.Properties.Resources.Mug;
            this.MugTwoPB.Location = new System.Drawing.Point(138, 205);
            this.MugTwoPB.Name = "MugTwoPB";
            this.MugTwoPB.Size = new System.Drawing.Size(57, 50);
            this.MugTwoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MugTwoPB.TabIndex = 5;
            this.MugTwoPB.TabStop = false;
            this.MugTwoPB.Click += new System.EventHandler(this.CabinetImgPB);
            // 
            // CabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.cabinetOpen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(474, 535);
            this.Controls.Add(this.MugTwoPB);
            this.Controls.Add(this.MugPB);
            this.Controls.Add(this.GlassThreePB);
            this.Controls.Add(this.GlassTwoPB);
            this.Controls.Add(this.GlassPB);
            this.Controls.Add(this.PlatePB);
            this.Name = "CabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CabinetForm";
            this.Load += new System.EventHandler(this.CabinetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlatePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassTwoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassThreePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MugPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MugTwoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlatePB;
        private System.Windows.Forms.PictureBox GlassPB;
        private System.Windows.Forms.PictureBox GlassTwoPB;
        private System.Windows.Forms.PictureBox GlassThreePB;
        private System.Windows.Forms.PictureBox MugPB;
        private System.Windows.Forms.PictureBox MugTwoPB;
    }
}