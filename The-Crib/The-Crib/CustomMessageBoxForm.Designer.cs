namespace The_Crib
{
    partial class CustomMessageBoxForm
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
            this.WordLB = new System.Windows.Forms.Label();
            this.ReturnBT = new System.Windows.Forms.Button();
            this.messBoxPnl = new System.Windows.Forms.Panel();
            this.borderR = new System.Windows.Forms.Panel();
            this.borderL = new System.Windows.Forms.Panel();
            this.borderT = new System.Windows.Forms.Panel();
            this.borderB = new System.Windows.Forms.Panel();
            this.messBoxPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // WordLB
            // 
            this.WordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLB.Location = new System.Drawing.Point(86, 47);
            this.WordLB.Name = "WordLB";
            this.WordLB.Size = new System.Drawing.Size(511, 78);
            this.WordLB.TabIndex = 0;
            this.WordLB.Text = "Volcabulary goes here";
            this.WordLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnBT
            // 
            this.ReturnBT.BackColor = System.Drawing.Color.CadetBlue;
            this.ReturnBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReturnBT.FlatAppearance.BorderSize = 0;
            this.ReturnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnBT.Location = new System.Drawing.Point(179, 145);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(332, 66);
            this.ReturnBT.TabIndex = 1;
            this.ReturnBT.Text = "OK";
            this.ReturnBT.UseVisualStyleBackColor = false;
            // 
            // messBoxPnl
            // 
            this.messBoxPnl.BackColor = System.Drawing.Color.CadetBlue;
            this.messBoxPnl.Controls.Add(this.borderB);
            this.messBoxPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messBoxPnl.Location = new System.Drawing.Point(0, 239);
            this.messBoxPnl.Name = "messBoxPnl";
            this.messBoxPnl.Size = new System.Drawing.Size(668, 42);
            this.messBoxPnl.TabIndex = 2;
            // 
            // borderR
            // 
            this.borderR.BackColor = System.Drawing.Color.LightGray;
            this.borderR.Location = new System.Drawing.Point(0, 0);
            this.borderR.Name = "borderR";
            this.borderR.Size = new System.Drawing.Size(5, 283);
            this.borderR.TabIndex = 3;
            // 
            // borderL
            // 
            this.borderL.BackColor = System.Drawing.Color.LightGray;
            this.borderL.Location = new System.Drawing.Point(663, -2);
            this.borderL.Name = "borderL";
            this.borderL.Size = new System.Drawing.Size(5, 283);
            this.borderL.TabIndex = 4;
            // 
            // borderT
            // 
            this.borderT.BackColor = System.Drawing.Color.LightGray;
            this.borderT.Location = new System.Drawing.Point(0, 0);
            this.borderT.Name = "borderT";
            this.borderT.Size = new System.Drawing.Size(662, 5);
            this.borderT.TabIndex = 5;
            // 
            // borderB
            // 
            this.borderB.BackColor = System.Drawing.Color.LightGray;
            this.borderB.Location = new System.Drawing.Point(6, 37);
            this.borderB.Name = "borderB";
            this.borderB.Size = new System.Drawing.Size(662, 5);
            this.borderB.TabIndex = 6;
            // 
            // CustomMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(668, 281);
            this.Controls.Add(this.borderT);
            this.Controls.Add(this.borderR);
            this.Controls.Add(this.borderL);
            this.Controls.Add(this.messBoxPnl);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.WordLB);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBoxForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBoxForm";
            this.messBoxPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WordLB;
        private System.Windows.Forms.Button ReturnBT;
        private System.Windows.Forms.Panel messBoxPnl;
        private System.Windows.Forms.Panel borderB;
        private System.Windows.Forms.Panel borderR;
        private System.Windows.Forms.Panel borderL;
        private System.Windows.Forms.Panel borderT;
    }
}