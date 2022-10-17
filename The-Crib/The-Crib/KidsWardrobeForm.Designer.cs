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
            this.shirtKRPB = new System.Windows.Forms.PictureBox();
            this.dressKRPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pantsKRPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirtKRPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dressKRPB)).BeginInit();
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
            // shirtKRPB
            // 
            this.shirtKRPB.BackColor = System.Drawing.Color.Transparent;
            this.shirtKRPB.BackgroundImage = global::The_Crib.Properties.Resources.Shirt_Kid_sRoom;
            this.shirtKRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shirtKRPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shirtKRPB.Location = new System.Drawing.Point(341, 92);
            this.shirtKRPB.Name = "shirtKRPB";
            this.shirtKRPB.Size = new System.Drawing.Size(114, 153);
            this.shirtKRPB.TabIndex = 1;
            this.shirtKRPB.TabStop = false;
            this.shirtKRPB.Click += new System.EventHandler(this.shirtKRPB_Click);
            // 
            // dressKRPB
            // 
            this.dressKRPB.BackColor = System.Drawing.Color.Transparent;
            this.dressKRPB.BackgroundImage = global::The_Crib.Properties.Resources.Dress_Kid_sRoom;
            this.dressKRPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dressKRPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dressKRPB.Location = new System.Drawing.Point(478, 92);
            this.dressKRPB.Name = "dressKRPB";
            this.dressKRPB.Size = new System.Drawing.Size(117, 170);
            this.dressKRPB.TabIndex = 2;
            this.dressKRPB.TabStop = false;
            this.dressKRPB.Click += new System.EventHandler(this.dressKRPB_Click);
            // 
            // KidsWardrobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::The_Crib.Properties.Resources.WardrobeOpen_Kid_sRoom_clothes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 630);
            this.Controls.Add(this.dressKRPB);
            this.Controls.Add(this.shirtKRPB);
            this.Controls.Add(this.pantsKRPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KidsWardrobeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KidsWardrobeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pantsKRPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirtKRPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dressKRPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pantsKRPB;
        private System.Windows.Forms.PictureBox shirtKRPB;
        private System.Windows.Forms.PictureBox dressKRPB;
    }
}