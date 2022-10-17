namespace The_Crib
{
    partial class DrawerForm
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
            this.ScissorsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ScissorsPB
            // 
            this.ScissorsPB.BackColor = System.Drawing.Color.Transparent;
            this.ScissorsPB.Image = global::The_Crib.Properties.Resources.Scissors;
            this.ScissorsPB.Location = new System.Drawing.Point(301, 191);
            this.ScissorsPB.Name = "ScissorsPB";
            this.ScissorsPB.Size = new System.Drawing.Size(419, 339);
            this.ScissorsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScissorsPB.TabIndex = 0;
            this.ScissorsPB.TabStop = false;
            this.ScissorsPB.Click += new System.EventHandler(this.DrawerImgPB);
            // 
            // DrawerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.drawer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 584);
            this.Controls.Add(this.ScissorsPB);
            this.Name = "DrawerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawerForm";
            this.Load += new System.EventHandler(this.DrawerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScissorsPB;
    }
}