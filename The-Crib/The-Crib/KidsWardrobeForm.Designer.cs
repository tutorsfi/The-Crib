namespace The_Crib
{
    partial class KidsWardrobeForm
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
            this.pantsKRPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pantsKRPB)).BeginInit();
            this.SuspendLayout();
            // 
            // pantsKRPB
            // 
            this.pantsKRPB.BackColor = System.Drawing.Color.Transparent;
            this.pantsKRPB.BackgroundImage = global::The_Crib.Properties.Resources.Pants_Kid_sRoom;
            this.pantsKRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantsKRPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pantsKRPB.Location = new System.Drawing.Point(154, 114);
            this.pantsKRPB.Name = "pantsKRPB";
            this.pantsKRPB.Size = new System.Drawing.Size(104, 177);
            this.pantsKRPB.TabIndex = 0;
            this.pantsKRPB.TabStop = false;
            this.pantsKRPB.Click += new System.EventHandler(this.pantsKRPB_Click);
            // 
            // KidsWardrobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::The_Crib.Properties.Resources.WardrobeOpen_Kid_sRoom_clothes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 630);
            this.Controls.Add(this.pantsKRPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KidsWardrobeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pantsKRPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pantsKRPB;
    }
}