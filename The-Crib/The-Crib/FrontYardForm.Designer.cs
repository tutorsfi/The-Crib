namespace The_Crib
{
    partial class FrontYardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontYardForm));
            this.HousePB = new System.Windows.Forms.PictureBox();
            this.DoorPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HousePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // HousePB
            // 
            this.HousePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HousePB.BackgroundImage")));
            this.HousePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousePB.InitialImage = null;
            this.HousePB.Location = new System.Drawing.Point(529, 492);
            this.HousePB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HousePB.Name = "HousePB";
            this.HousePB.Size = new System.Drawing.Size(780, 313);
            this.HousePB.TabIndex = 0;
            this.HousePB.TabStop = false;
            this.HousePB.Click += new System.EventHandler(this.HousePB_Click);
            // 
            // DoorPB
            // 
            this.DoorPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoorPB.BackgroundImage")));
            this.DoorPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoorPB.Location = new System.Drawing.Point(874, 662);
            this.DoorPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoorPB.Name = "DoorPB";
            this.DoorPB.Size = new System.Drawing.Size(100, 133);
            this.DoorPB.TabIndex = 1;
            this.DoorPB.TabStop = false;
            this.DoorPB.Click += new System.EventHandler(this.DoorPB_Click);
            // 
            // FrontYardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1632, 883);
            this.Controls.Add(this.DoorPB);
            this.Controls.Add(this.HousePB);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrontYardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontYardForm";
            this.Load += new System.EventHandler(this.FrontYardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HousePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HousePB;
        private System.Windows.Forms.PictureBox DoorPB;
    }
}