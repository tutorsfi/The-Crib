namespace The_Crib
{
    partial class WcForm
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
            this.WcDoorPB = new System.Windows.Forms.PictureBox();
            this.SinkPB = new System.Windows.Forms.PictureBox();
            this.ToiletPB = new System.Windows.Forms.PictureBox();
            this.LampPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WcDoorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToiletPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampPB)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLanguageBt
            // 
            this.SelectLanguageBt.Location = new System.Drawing.Point(12, 12);
            this.SelectLanguageBt.Name = "SelectLanguageBt";
            this.SelectLanguageBt.Size = new System.Drawing.Size(109, 28);
            this.SelectLanguageBt.TabIndex = 5;
            this.SelectLanguageBt.Text = "Select language";
            this.SelectLanguageBt.UseVisualStyleBackColor = true;
            this.SelectLanguageBt.Click += new System.EventHandler(this.SelectLanguageBt_Click);
            // 
            // WcDoorPB
            // 
            this.WcDoorPB.BackColor = System.Drawing.Color.Transparent;
            this.WcDoorPB.Image = global::The_Crib.Properties.Resources.DoorToLeft;
            this.WcDoorPB.Location = new System.Drawing.Point(25, 273);
            this.WcDoorPB.Name = "WcDoorPB";
            this.WcDoorPB.Size = new System.Drawing.Size(141, 647);
            this.WcDoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WcDoorPB.TabIndex = 6;
            this.WcDoorPB.TabStop = false;
            this.WcDoorPB.Click += new System.EventHandler(this.WcDoorPB_Click);
            // 
            // SinkPB
            // 
            this.SinkPB.BackColor = System.Drawing.Color.Transparent;
            this.SinkPB.Image = global::The_Crib.Properties.Resources.Sink_Bathroom;
            this.SinkPB.Location = new System.Drawing.Point(846, 534);
            this.SinkPB.Name = "SinkPB";
            this.SinkPB.Size = new System.Drawing.Size(192, 298);
            this.SinkPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SinkPB.TabIndex = 7;
            this.SinkPB.TabStop = false;
            this.SinkPB.Click += new System.EventHandler(this.ToiletImgPB);
            // 
            // ToiletPB
            // 
            this.ToiletPB.BackColor = System.Drawing.Color.Transparent;
            this.ToiletPB.Image = global::The_Crib.Properties.Resources.ToiletBowl;
            this.ToiletPB.Location = new System.Drawing.Point(1072, 513);
            this.ToiletPB.Name = "ToiletPB";
            this.ToiletPB.Size = new System.Drawing.Size(187, 332);
            this.ToiletPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToiletPB.TabIndex = 8;
            this.ToiletPB.TabStop = false;
            this.ToiletPB.Click += new System.EventHandler(this.ToiletImgPB);
            // 
            // LampPB
            // 
            this.LampPB.BackColor = System.Drawing.Color.Transparent;
            this.LampPB.Image = global::The_Crib.Properties.Resources.CeilingLamp;
            this.LampPB.Location = new System.Drawing.Point(566, -2);
            this.LampPB.Name = "LampPB";
            this.LampPB.Size = new System.Drawing.Size(281, 121);
            this.LampPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LampPB.TabIndex = 9;
            this.LampPB.TabStop = false;
            this.LampPB.Click += new System.EventHandler(this.ToiletImgPB);
            // 
            // WcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.WC;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.LampPB);
            this.Controls.Add(this.ToiletPB);
            this.Controls.Add(this.SinkPB);
            this.Controls.Add(this.WcDoorPB);
            this.Controls.Add(this.SelectLanguageBt);
            this.Name = "WcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WcForm";
            this.Load += new System.EventHandler(this.WcForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WcDoorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToiletPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectLanguageBt;
        private System.Windows.Forms.PictureBox WcDoorPB;
        private System.Windows.Forms.PictureBox SinkPB;
        private System.Windows.Forms.PictureBox ToiletPB;
        private System.Windows.Forms.PictureBox LampPB;
    }
}