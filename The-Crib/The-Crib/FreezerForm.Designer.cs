namespace The_Crib
{
    partial class FreezerForm
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
            this.PizzaPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaPB
            // 
            this.PizzaPB.BackColor = System.Drawing.Color.Transparent;
            this.PizzaPB.Image = global::The_Crib.Properties.Resources.FrozenPizza;
            this.PizzaPB.Location = new System.Drawing.Point(108, 215);
            this.PizzaPB.Name = "PizzaPB";
            this.PizzaPB.Size = new System.Drawing.Size(117, 40);
            this.PizzaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PizzaPB.TabIndex = 0;
            this.PizzaPB.TabStop = false;
            this.PizzaPB.Click += new System.EventHandler(this.FreezerImgPB);
            // 
            // FreezerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.freezerBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(349, 368);
            this.Controls.Add(this.PizzaPB);
            this.Name = "FreezerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreezerForm";
            this.Load += new System.EventHandler(this.FreezerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PizzaPB;
    }
}