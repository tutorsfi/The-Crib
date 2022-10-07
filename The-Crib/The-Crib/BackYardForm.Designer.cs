namespace The_Crib
{
    partial class BackYardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackYardForm));
            this.HousePB = new System.Windows.Forms.PictureBox();
            this.RoofPB = new System.Windows.Forms.PictureBox();
            this.DoorPB = new System.Windows.Forms.PictureBox();
            this.WindowDRPB = new System.Windows.Forms.PictureBox();
            this.WindowKRPB = new System.Windows.Forms.PictureBox();
            this.WindowSRPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HousePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoofPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowDRPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowKRPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowSRPB)).BeginInit();
            this.SuspendLayout();
            // 
            // HousePB
            // 
            this.HousePB.BackColor = System.Drawing.Color.Transparent;
            this.HousePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HousePB.BackgroundImage")));
            this.HousePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousePB.Location = new System.Drawing.Point(479, 275);
            this.HousePB.Name = "HousePB";
            this.HousePB.Size = new System.Drawing.Size(780, 364);
            this.HousePB.TabIndex = 0;
            this.HousePB.TabStop = false;
            // 
            // RoofPB
            // 
            this.RoofPB.BackColor = System.Drawing.Color.Transparent;
            this.RoofPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoofPB.BackgroundImage")));
            this.RoofPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RoofPB.Location = new System.Drawing.Point(479, 232);
            this.RoofPB.Name = "RoofPB";
            this.RoofPB.Size = new System.Drawing.Size(780, 50);
            this.RoofPB.TabIndex = 1;
            this.RoofPB.TabStop = false;
            // 
            // DoorPB
            // 
            this.DoorPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoorPB.BackgroundImage")));
            this.DoorPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoorPB.Location = new System.Drawing.Point(599, 469);
            this.DoorPB.Name = "DoorPB";
            this.DoorPB.Size = new System.Drawing.Size(100, 157);
            this.DoorPB.TabIndex = 2;
            this.DoorPB.TabStop = false;
            this.DoorPB.Click += new System.EventHandler(this.DoorPB_Click);
            // 
            // WindowDRPB
            // 
            this.WindowDRPB.BackColor = System.Drawing.Color.DarkOrange;
            this.WindowDRPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WindowDRPB.BackgroundImage")));
            this.WindowDRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowDRPB.Location = new System.Drawing.Point(1003, 482);
            this.WindowDRPB.Name = "WindowDRPB";
            this.WindowDRPB.Size = new System.Drawing.Size(160, 116);
            this.WindowDRPB.TabIndex = 3;
            this.WindowDRPB.TabStop = false;
            // 
            // WindowKRPB
            // 
            this.WindowKRPB.BackColor = System.Drawing.Color.DarkOrange;
            this.WindowKRPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WindowKRPB.BackgroundImage")));
            this.WindowKRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowKRPB.Location = new System.Drawing.Point(522, 322);
            this.WindowKRPB.Name = "WindowKRPB";
            this.WindowKRPB.Size = new System.Drawing.Size(160, 116);
            this.WindowKRPB.TabIndex = 4;
            this.WindowKRPB.TabStop = false;
            // 
            // WindowSRPB
            // 
            this.WindowSRPB.BackColor = System.Drawing.Color.DarkOrange;
            this.WindowSRPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WindowSRPB.BackgroundImage")));
            this.WindowSRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowSRPB.Location = new System.Drawing.Point(1003, 322);
            this.WindowSRPB.Name = "WindowSRPB";
            this.WindowSRPB.Size = new System.Drawing.Size(160, 116);
            this.WindowSRPB.TabIndex = 5;
            this.WindowSRPB.TabStop = false;
            // 
            // BackYardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1632, 883);
            this.Controls.Add(this.WindowSRPB);
            this.Controls.Add(this.WindowKRPB);
            this.Controls.Add(this.WindowDRPB);
            this.Controls.Add(this.DoorPB);
            this.Controls.Add(this.RoofPB);
            this.Controls.Add(this.HousePB);
            this.DoubleBuffered = true;
            this.Name = "BackYardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackYardForm";
            this.Load += new System.EventHandler(this.BackYardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HousePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoofPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowDRPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowKRPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowSRPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HousePB;
        private System.Windows.Forms.PictureBox RoofPB;
        private System.Windows.Forms.PictureBox DoorPB;
        private System.Windows.Forms.PictureBox WindowDRPB;
        private System.Windows.Forms.PictureBox WindowKRPB;
        private System.Windows.Forms.PictureBox WindowSRPB;
    }
}