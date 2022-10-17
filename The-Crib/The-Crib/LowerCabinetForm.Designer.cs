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
            ((System.ComponentModel.ISupportInitialize)(this.PotPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PotPB
            // 
            this.PotPB.BackColor = System.Drawing.Color.Transparent;
            this.PotPB.Image = global::The_Crib.Properties.Resources.Pot;
            this.PotPB.Location = new System.Drawing.Point(101, 205);
            this.PotPB.Name = "PotPB";
            this.PotPB.Size = new System.Drawing.Size(122, 72);
            this.PotPB.TabIndex = 0;
            this.PotPB.TabStop = false;
            this.PotPB.Click += new System.EventHandler(this.LowerCabinetImgPB);
            // 
            // LowerCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.LowerCabinetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(341, 336);
            this.Controls.Add(this.PotPB);
            this.Name = "LowerCabinetForm";
            this.Text = "LowerCabinetForm";
            this.Load += new System.EventHandler(this.LowerCabinetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PotPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PotPB;
    }
}