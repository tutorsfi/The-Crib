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
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).BeginInit();
            this.SuspendLayout();
            // 
            // SinkPB
            // 
            this.SinkPB.BackColor = System.Drawing.Color.Transparent;
            this.SinkPB.BackgroundImage = global::The_Crib.Properties.Resources.LowerCabinet11;
            this.SinkPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SinkPB.Image = global::The_Crib.Properties.Resources.Sink1;
            this.SinkPB.Location = new System.Drawing.Point(682, 471);
            this.SinkPB.Name = "SinkPB";
            this.SinkPB.Size = new System.Drawing.Size(221, 292);
            this.SinkPB.TabIndex = 0;
            this.SinkPB.TabStop = false;
            // 
            // BathroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.Bathroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.SinkPB);
            this.Name = "BathroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BathroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.SinkPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SinkPB;
    }
}