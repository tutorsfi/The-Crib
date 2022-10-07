namespace The_Crib
{
    partial class MasterBedroomForm
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
            this.ceilingLampMBPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ceilingLampMBPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ceilingLampMBPB
            // 
            this.ceilingLampMBPB.BackColor = System.Drawing.Color.Transparent;
            this.ceilingLampMBPB.BackgroundImage = global::The_Crib.Properties.Resources.CeilingLamp;
            this.ceilingLampMBPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ceilingLampMBPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceilingLampMBPB.Location = new System.Drawing.Point(510, -11);
            this.ceilingLampMBPB.Name = "ceilingLampMBPB";
            this.ceilingLampMBPB.Size = new System.Drawing.Size(313, 165);
            this.ceilingLampMBPB.TabIndex = 0;
            this.ceilingLampMBPB.TabStop = false;
            this.ceilingLampMBPB.Click += new System.EventHandler(this.ceilingLampMBPB_Click);
            // 
            // MasterBedroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.MasterBedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1632, 883);
            this.Controls.Add(this.ceilingLampMBPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MasterBedroomForm";
            this.Text = "MasterBedroomForm";
            this.Load += new System.EventHandler(this.MasterBedroomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ceilingLampMBPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ceilingLampMBPB;
    }
}