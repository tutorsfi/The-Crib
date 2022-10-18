namespace The_Crib
{
    partial class MasterBedroomWardrobeForm
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
            this.dressMBPB = new System.Windows.Forms.PictureBox();
            this.suitMBPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dressMBPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitMBPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dressMBPB
            // 
            this.dressMBPB.BackColor = System.Drawing.Color.Transparent;
            this.dressMBPB.BackgroundImage = global::The_Crib.Properties.Resources.Dress_MasterBedroom;
            this.dressMBPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dressMBPB.Location = new System.Drawing.Point(87, 59);
            this.dressMBPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dressMBPB.Name = "dressMBPB";
            this.dressMBPB.Size = new System.Drawing.Size(168, 352);
            this.dressMBPB.TabIndex = 0;
            this.dressMBPB.TabStop = false;
            this.dressMBPB.Click += new System.EventHandler(this.dressMBPB_Click);
            // 
            // suitMBPB
            // 
            this.suitMBPB.BackColor = System.Drawing.Color.Transparent;
            this.suitMBPB.BackgroundImage = global::The_Crib.Properties.Resources.Suit1;
            this.suitMBPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.suitMBPB.Location = new System.Drawing.Point(259, 11);
            this.suitMBPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suitMBPB.Name = "suitMBPB";
            this.suitMBPB.Size = new System.Drawing.Size(131, 489);
            this.suitMBPB.TabIndex = 1;
            this.suitMBPB.TabStop = false;
            this.suitMBPB.Click += new System.EventHandler(this.suitMBPB_Click);
            // 
            // MasterBedroomWardrobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::The_Crib.Properties.Resources.WardrobeOpen_MasterBedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 690);
            this.Controls.Add(this.suitMBPB);
            this.Controls.Add(this.dressMBPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterBedroomWardrobeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterBedroomWardrobeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dressMBPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitMBPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dressMBPB;
        private System.Windows.Forms.PictureBox suitMBPB;
    }
}