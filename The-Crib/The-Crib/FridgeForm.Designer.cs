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
            this.MilkPB = new System.Windows.Forms.PictureBox();
            this.OrangejuicePB = new System.Windows.Forms.PictureBox();
            this.EggsPB = new System.Windows.Forms.PictureBox();
            this.MargarinePB = new System.Windows.Forms.PictureBox();
            this.TomatoesPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CucumberPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangejuicePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EggsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MargarinePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoesPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CucumberPB
            // 
            this.CucumberPB.BackColor = System.Drawing.Color.Transparent;
            this.CucumberPB.Image = global::The_Crib.Properties.Resources.Cucumber;
            this.CucumberPB.Location = new System.Drawing.Point(60, 454);
            this.CucumberPB.Name = "CucumberPB";
            this.CucumberPB.Size = new System.Drawing.Size(144, 19);
            this.CucumberPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CucumberPB.TabIndex = 0;
            this.CucumberPB.TabStop = false;
            this.CucumberPB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // MilkPB
            // 
            this.MilkPB.BackColor = System.Drawing.Color.Transparent;
            this.MilkPB.Image = global::The_Crib.Properties.Resources.MilkCarton;
            this.MilkPB.Location = new System.Drawing.Point(396, 299);
            this.MilkPB.Name = "MilkPB";
            this.MilkPB.Size = new System.Drawing.Size(58, 98);
            this.MilkPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MilkPB.TabIndex = 1;
            this.MilkPB.TabStop = false;
            this.MilkPB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // OrangejuicePB
            // 
            this.OrangejuicePB.BackColor = System.Drawing.Color.Transparent;
            this.OrangejuicePB.Image = global::The_Crib.Properties.Resources.OrangeJuiceCarton;
            this.OrangejuicePB.Location = new System.Drawing.Point(470, 289);
            this.OrangejuicePB.Name = "OrangejuicePB";
            this.OrangejuicePB.Size = new System.Drawing.Size(58, 114);
            this.OrangejuicePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrangejuicePB.TabIndex = 2;
            this.OrangejuicePB.TabStop = false;
            this.OrangejuicePB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // EggsPB
            // 
            this.EggsPB.BackColor = System.Drawing.Color.Transparent;
            this.EggsPB.Image = global::The_Crib.Properties.Resources.Eggs;
            this.EggsPB.Location = new System.Drawing.Point(235, 414);
            this.EggsPB.Name = "EggsPB";
            this.EggsPB.Size = new System.Drawing.Size(125, 69);
            this.EggsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EggsPB.TabIndex = 3;
            this.EggsPB.TabStop = false;
            this.EggsPB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // MargarinePB
            // 
            this.MargarinePB.BackColor = System.Drawing.Color.Transparent;
            this.MargarinePB.Image = global::The_Crib.Properties.Resources.Margarine;
            this.MargarinePB.Location = new System.Drawing.Point(81, 267);
            this.MargarinePB.Name = "MargarinePB";
            this.MargarinePB.Size = new System.Drawing.Size(87, 45);
            this.MargarinePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MargarinePB.TabIndex = 4;
            this.MargarinePB.TabStop = false;
            this.MargarinePB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // TomatoesPB
            // 
            this.TomatoesPB.BackColor = System.Drawing.Color.Transparent;
            this.TomatoesPB.Image = global::The_Crib.Properties.Resources.Tomatoes;
            this.TomatoesPB.Location = new System.Drawing.Point(77, 480);
            this.TomatoesPB.Name = "TomatoesPB";
            this.TomatoesPB.Size = new System.Drawing.Size(136, 41);
            this.TomatoesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TomatoesPB.TabIndex = 5;
            this.TomatoesPB.TabStop = false;
            this.TomatoesPB.Click += new System.EventHandler(this.FridgeImgPB);
            // 
            // FridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.fridgebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(671, 684);
            this.Controls.Add(this.TomatoesPB);
            this.Controls.Add(this.MargarinePB);
            this.Controls.Add(this.EggsPB);
            this.Controls.Add(this.OrangejuicePB);
            this.Controls.Add(this.MilkPB);
            this.Controls.Add(this.CucumberPB);
            this.Name = "FridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FridgeForm";
            this.Load += new System.EventHandler(this.FridgeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CucumberPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangejuicePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EggsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MargarinePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoesPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CucumberPB;
        private System.Windows.Forms.PictureBox MilkPB;
        private System.Windows.Forms.PictureBox OrangejuicePB;
        private System.Windows.Forms.PictureBox EggsPB;
        private System.Windows.Forms.PictureBox MargarinePB;
        private System.Windows.Forms.PictureBox TomatoesPB;
    }
}