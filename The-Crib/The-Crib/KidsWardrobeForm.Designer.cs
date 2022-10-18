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
            this.pantsKRPB.Location = new System.Drawing.Point(116, 93);
            this.pantsKRPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pantsKRPB.Name = "pantsKRPB";
            this.pantsKRPB.Size = new System.Drawing.Size(78, 144);
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
            this.shirtKRPB.Location = new System.Drawing.Point(256, 75);
            this.shirtKRPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shirtKRPB.Name = "shirtKRPB";
            this.shirtKRPB.Size = new System.Drawing.Size(86, 124);
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
            this.dressKRPB.Location = new System.Drawing.Point(358, 75);
            this.dressKRPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dressKRPB.Name = "dressKRPB";
            this.dressKRPB.Size = new System.Drawing.Size(88, 138);
            this.dressKRPB.TabIndex = 2;
            this.dressKRPB.TabStop = false;
            this.dressKRPB.Click += new System.EventHandler(this.dressKRPB_Click);
            // 
            // KidsWardrobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::The_Crib.Properties.Resources.WardrobeOpen_Kid_sRoom_clothes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(527, 512);
            this.Controls.Add(this.dressKRPB);
            this.Controls.Add(this.shirtKRPB);
            this.Controls.Add(this.pantsKRPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KidsWardrobeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KidsWardrobeForm_FormClosed);
            this.Load += new System.EventHandler(this.KidsWardrobeForm_Load);
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