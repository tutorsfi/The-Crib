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
            this.SelectLanguageBt = new System.Windows.Forms.Button();
            this.WashingMachinePB = new System.Windows.Forms.PictureBox();
            this.ToiletPB = new System.Windows.Forms.PictureBox();
            this.ShowerPB = new System.Windows.Forms.PictureBox();
            this.SinkPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WashingMachinePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToiletPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).BeginInit();
            this.SuspendLayout();
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
            // WashingMachinePB
            // 
            this.WashingMachinePB.BackColor = System.Drawing.Color.Transparent;
            this.WashingMachinePB.Image = global::The_Crib.Properties.Resources.WashingMachine;
            this.WashingMachinePB.Location = new System.Drawing.Point(277, 387);
            this.WashingMachinePB.Name = "WashingMachinePB";
            this.WashingMachinePB.Size = new System.Drawing.Size(300, 366);
            this.WashingMachinePB.TabIndex = 3;
            this.WashingMachinePB.TabStop = false;
            this.WashingMachinePB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // ToiletPB
            // 
            this.ToiletPB.BackColor = System.Drawing.Color.Transparent;
            this.ToiletPB.Image = global::The_Crib.Properties.Resources.ToiletBowl;
            this.ToiletPB.Location = new System.Drawing.Point(819, 387);
            this.ToiletPB.Name = "ToiletPB";
            this.ToiletPB.Size = new System.Drawing.Size(197, 380);
            this.ToiletPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToiletPB.TabIndex = 4;
            this.ToiletPB.TabStop = false;
            this.ToiletPB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // ShowerPB
            // 
            this.ShowerPB.BackColor = System.Drawing.Color.Transparent;
            this.ShowerPB.Image = global::The_Crib.Properties.Resources.Shower;
            this.ShowerPB.Location = new System.Drawing.Point(1268, 12);
            this.ShowerPB.Name = "ShowerPB";
            this.ShowerPB.Size = new System.Drawing.Size(298, 424);
            this.ShowerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowerPB.TabIndex = 5;
            this.ShowerPB.TabStop = false;
            this.ShowerPB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // SinkPB
            // 
            this.SinkPB.BackColor = System.Drawing.Color.Transparent;
            this.SinkPB.Image = global::The_Crib.Properties.Resources.Sink_Bathroom;
            this.SinkPB.Location = new System.Drawing.Point(592, 387);
            this.SinkPB.Name = "SinkPB";
            this.SinkPB.Size = new System.Drawing.Size(208, 349);
            this.SinkPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SinkPB.TabIndex = 6;
            this.SinkPB.TabStop = false;
            this.SinkPB.Click += new System.EventHandler(this.BathroomImgPB);
            // 
            // BathroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.BathroomFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.SinkPB);
            this.Controls.Add(this.ShowerPB);
            this.Controls.Add(this.ToiletPB);
            this.Controls.Add(this.WashingMachinePB);
            this.Controls.Add(this.SelectLanguageBt);
            this.Name = "BathroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BathroomForm";
            this.Load += new System.EventHandler(this.BathroomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WashingMachinePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToiletPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SelectLanguageBt;
        private System.Windows.Forms.PictureBox WashingMachinePB;
        private System.Windows.Forms.PictureBox ToiletPB;
        private System.Windows.Forms.PictureBox ShowerPB;
        private System.Windows.Forms.PictureBox SinkPB;
    }
}