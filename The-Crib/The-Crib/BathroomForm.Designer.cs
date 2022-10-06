namespace The_Crib
{
    partial class BathroomForm
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
            this.SinkPB = new System.Windows.Forms.PictureBox();
            this.TapPB = new System.Windows.Forms.PictureBox();
            this.SelectLanguageBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TapPB)).BeginInit();
            this.SuspendLayout();
            // 
            // SinkPB
            // 
            this.SinkPB.BackColor = System.Drawing.Color.Transparent;
            this.SinkPB.BackgroundImage = global::The_Crib.Properties.Resources.Sink;
            this.SinkPB.Location = new System.Drawing.Point(561, 469);
            this.SinkPB.Name = "SinkPB";
            this.SinkPB.Size = new System.Drawing.Size(216, 50);
            this.SinkPB.TabIndex = 0;
            this.SinkPB.TabStop = false;
            this.SinkPB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // TapPB
            // 
            this.TapPB.BackColor = System.Drawing.Color.Transparent;
            this.TapPB.Image = global::The_Crib.Properties.Resources.Tap;
            this.TapPB.Location = new System.Drawing.Point(648, 417);
            this.TapPB.Name = "TapPB";
            this.TapPB.Size = new System.Drawing.Size(52, 65);
            this.TapPB.TabIndex = 1;
            this.TapPB.TabStop = false;
            this.TapPB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // SelectLanguageBt
            // 
            this.SelectLanguageBt.Location = new System.Drawing.Point(12, 12);
            this.SelectLanguageBt.Name = "SelectLanguageBt";
            this.SelectLanguageBt.Size = new System.Drawing.Size(109, 28);
            this.SelectLanguageBt.TabIndex = 2;
            this.SelectLanguageBt.Text = "Select language";
            this.SelectLanguageBt.UseVisualStyleBackColor = true;
            this.SelectLanguageBt.Click += new System.EventHandler(this.SelectLanguageBt_Click);
            // 
            // BathroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.Bathroom2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.SelectLanguageBt);
            this.Controls.Add(this.TapPB);
            this.Controls.Add(this.SinkPB);
            this.Name = "BathroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BathroomForm";
            this.Load += new System.EventHandler(this.BathroomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TapPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SinkPB;
        private System.Windows.Forms.PictureBox TapPB;
        private System.Windows.Forms.Button SelectLanguageBt;
    }
}