namespace The_Crib
{
    partial class FridgeForm
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
            this.CucumberPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CucumberPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CucumberPB
            // 
            this.CucumberPB.BackColor = System.Drawing.Color.Transparent;
            this.CucumberPB.Image = global::The_Crib.Properties.Resources.Cucumber;
            this.CucumberPB.Location = new System.Drawing.Point(33, 223);
            this.CucumberPB.Name = "CucumberPB";
            this.CucumberPB.Size = new System.Drawing.Size(89, 11);
            this.CucumberPB.TabIndex = 0;
            this.CucumberPB.TabStop = false;
            this.CucumberPB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // FridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.fridgebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(339, 345);
            this.Controls.Add(this.CucumberPB);
            this.Name = "FridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FridgeForm";
            this.Load += new System.EventHandler(this.FridgeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CucumberPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CucumberPB;
    }
}