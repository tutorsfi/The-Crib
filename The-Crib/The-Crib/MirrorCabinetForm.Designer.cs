namespace The_Crib
{
    partial class MirrorCabinetForm
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
            this.ToothbrushPB = new System.Windows.Forms.PictureBox();
            this.ToothpastePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToothbrushPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToothpastePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ToothbrushPB
            // 
            this.ToothbrushPB.BackColor = System.Drawing.Color.IndianRed;
            this.ToothbrushPB.Location = new System.Drawing.Point(158, 289);
            this.ToothbrushPB.Name = "ToothbrushPB";
            this.ToothbrushPB.Size = new System.Drawing.Size(89, 35);
            this.ToothbrushPB.TabIndex = 0;
            this.ToothbrushPB.TabStop = false;
            this.ToothbrushPB.Click += new System.EventHandler(this.MirrorCabinetImgPB);
            // 
            // ToothpastePB
            // 
            this.ToothpastePB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToothpastePB.Location = new System.Drawing.Point(301, 289);
            this.ToothpastePB.Name = "ToothpastePB";
            this.ToothpastePB.Size = new System.Drawing.Size(89, 34);
            this.ToothpastePB.TabIndex = 1;
            this.ToothpastePB.TabStop = false;
            this.ToothpastePB.Click += new System.EventHandler(this.MirrorCabinetImgPB);
            // 
            // MirrorCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.mirrorcabinetbg;
            this.ClientSize = new System.Drawing.Size(545, 425);
            this.Controls.Add(this.ToothpastePB);
            this.Controls.Add(this.ToothbrushPB);
            this.Name = "MirrorCabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MirrorCabinetForm";
            this.Load += new System.EventHandler(this.MirrorCabinetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToothbrushPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToothpastePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ToothbrushPB;
        private System.Windows.Forms.PictureBox ToothpastePB;
    }
}