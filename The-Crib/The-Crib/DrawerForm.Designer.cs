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
            this.ForkPB = new System.Windows.Forms.PictureBox();
            this.SpoonPB = new System.Windows.Forms.PictureBox();
            this.KnifePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForkPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnifePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ScissorsPB
            // 
            this.ScissorsPB.BackColor = System.Drawing.Color.Transparent;
            this.ScissorsPB.Image = global::The_Crib.Properties.Resources.Scissors;
            this.ScissorsPB.Location = new System.Drawing.Point(314, 130);
            this.ScissorsPB.Name = "ScissorsPB";
            this.ScissorsPB.Size = new System.Drawing.Size(277, 300);
            this.ScissorsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScissorsPB.TabIndex = 0;
            this.ScissorsPB.TabStop = false;
            this.ScissorsPB.Click += new System.EventHandler(this.DrawerImgPB);
            // 
            // ForkPB
            // 
            this.ForkPB.BackColor = System.Drawing.Color.Transparent;
            this.ForkPB.Image = global::The_Crib.Properties.Resources.Fork;
            this.ForkPB.Location = new System.Drawing.Point(268, 44);
            this.ForkPB.Name = "ForkPB";
            this.ForkPB.Size = new System.Drawing.Size(52, 365);
            this.ForkPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ForkPB.TabIndex = 1;
            this.ForkPB.TabStop = false;
            this.ForkPB.Click += new System.EventHandler(this.DrawerImgPB);
            // 
            // SpoonPB
            // 
            this.SpoonPB.BackColor = System.Drawing.Color.Transparent;
            this.SpoonPB.Image = global::The_Crib.Properties.Resources.Spoon;
            this.SpoonPB.Location = new System.Drawing.Point(176, 62);
            this.SpoonPB.Name = "SpoonPB";
            this.SpoonPB.Size = new System.Drawing.Size(77, 358);
            this.SpoonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpoonPB.TabIndex = 2;
            this.SpoonPB.TabStop = false;
            this.SpoonPB.Click += new System.EventHandler(this.DrawerImgPB);
            // 
            // KnifePB
            // 
            this.KnifePB.BackColor = System.Drawing.Color.Transparent;
            this.KnifePB.Image = global::The_Crib.Properties.Resources.Knife;
            this.KnifePB.Location = new System.Drawing.Point(75, 54);
            this.KnifePB.Name = "KnifePB";
            this.KnifePB.Size = new System.Drawing.Size(112, 344);
            this.KnifePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KnifePB.TabIndex = 3;
            this.KnifePB.TabStop = false;
            this.KnifePB.Click += new System.EventHandler(this.DrawerImgPB);
            // 
            // DrawerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.drawer_filled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(657, 461);
            this.Controls.Add(this.KnifePB);
            this.Controls.Add(this.SpoonPB);
            this.Controls.Add(this.ForkPB);
            this.Controls.Add(this.ScissorsPB);
            this.Name = "DrawerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawerForm";
            this.Load += new System.EventHandler(this.DrawerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForkPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnifePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScissorsPB;
        private System.Windows.Forms.PictureBox ForkPB;
        private System.Windows.Forms.PictureBox SpoonPB;
        private System.Windows.Forms.PictureBox KnifePB;
    }
}