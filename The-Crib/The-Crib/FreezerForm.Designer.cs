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
            this.BerriesPB = new System.Windows.Forms.PictureBox();
            this.VeggiesPB = new System.Windows.Forms.PictureBox();
            this.IcecreamPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerriesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeggiesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcecreamPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaPB
            // 
            this.PizzaPB.BackColor = System.Drawing.Color.Transparent;
            this.PizzaPB.Image = global::The_Crib.Properties.Resources.FrozenPizza;
            this.PizzaPB.Location = new System.Drawing.Point(80, 285);
            this.PizzaPB.Name = "PizzaPB";
            this.PizzaPB.Size = new System.Drawing.Size(191, 57);
            this.PizzaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PizzaPB.TabIndex = 0;
            this.PizzaPB.TabStop = false;
            this.PizzaPB.Click += new System.EventHandler(this.FreezerImgPB);
            // 
            // BerriesPB
            // 
            this.BerriesPB.BackColor = System.Drawing.Color.Transparent;
            this.BerriesPB.Image = global::The_Crib.Properties.Resources.FrozenBerries;
            this.BerriesPB.Location = new System.Drawing.Point(301, 402);
            this.BerriesPB.Name = "BerriesPB";
            this.BerriesPB.Size = new System.Drawing.Size(86, 73);
            this.BerriesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BerriesPB.TabIndex = 1;
            this.BerriesPB.TabStop = false;
            this.BerriesPB.Click += new System.EventHandler(this.FreezerImgPB);
            // 
            // VeggiesPB
            // 
            this.VeggiesPB.BackColor = System.Drawing.Color.Transparent;
            this.VeggiesPB.Image = global::The_Crib.Properties.Resources.FrozenVegetables;
            this.VeggiesPB.Location = new System.Drawing.Point(80, 443);
            this.VeggiesPB.Name = "VeggiesPB";
            this.VeggiesPB.Size = new System.Drawing.Size(125, 56);
            this.VeggiesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VeggiesPB.TabIndex = 2;
            this.VeggiesPB.TabStop = false;
            this.VeggiesPB.Click += new System.EventHandler(this.FreezerImgPB);
            // 
            // IcecreamPB
            // 
            this.IcecreamPB.BackColor = System.Drawing.Color.Transparent;
            this.IcecreamPB.Image = global::The_Crib.Properties.Resources.IceCream;
            this.IcecreamPB.Location = new System.Drawing.Point(69, 137);
            this.IcecreamPB.Name = "IcecreamPB";
            this.IcecreamPB.Size = new System.Drawing.Size(114, 47);
            this.IcecreamPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IcecreamPB.TabIndex = 3;
            this.IcecreamPB.TabStop = false;
            this.IcecreamPB.Click += new System.EventHandler(this.FreezerImgPB);
            // 
            // FreezerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.freezerBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(701, 733);
            this.Controls.Add(this.IcecreamPB);
            this.Controls.Add(this.VeggiesPB);
            this.Controls.Add(this.BerriesPB);
            this.Controls.Add(this.PizzaPB);
            this.Name = "FreezerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreezerForm";
            this.Load += new System.EventHandler(this.FreezerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerriesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeggiesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcecreamPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PizzaPB;
        private System.Windows.Forms.PictureBox BerriesPB;
        private System.Windows.Forms.PictureBox VeggiesPB;
        private System.Windows.Forms.PictureBox IcecreamPB;
    }
}