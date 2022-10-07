namespace The_Crib
{
    partial class CustomDoorMessageBox
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
            this.ChangeFormBT = new System.Windows.Forms.Button();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            this.MessBoxPNL = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.MessBoxPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // WordLB
            // 
            this.WordLB.AutoSize = true;
            this.WordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLB.Location = new System.Drawing.Point(225, 48);
            this.WordLB.Name = "WordLB";
            this.WordLB.Size = new System.Drawing.Size(103, 38);
            this.WordLB.TabIndex = 0;
            this.WordLB.Text = "label1";
            this.WordLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnBT
            // 
            this.ReturnBT.BackColor = System.Drawing.Color.CadetBlue;
            this.ReturnBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReturnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnBT.Location = new System.Drawing.Point(100, 160);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(133, 46);
            this.ReturnBT.TabIndex = 1;
            this.ReturnBT.Text = "Ok";
            this.ReturnBT.UseVisualStyleBackColor = false;
            // 
            // ChangeFormBT
            // 
            this.ChangeFormBT.BackColor = System.Drawing.Color.CadetBlue;
            this.ChangeFormBT.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ChangeFormBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeFormBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFormBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeFormBT.Location = new System.Drawing.Point(402, 160);
            this.ChangeFormBT.Name = "ChangeFormBT";
            this.ChangeFormBT.Size = new System.Drawing.Size(133, 46);
            this.ChangeFormBT.TabIndex = 1;
            this.ChangeFormBT.Text = "Enter";
            this.ChangeFormBT.UseVisualStyleBackColor = false;
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.LightGray;
            this.BorderTop.Location = new System.Drawing.Point(3, 1);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(662, 5);
            this.BorderTop.TabIndex = 5;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.LightGray;
            this.BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(5, 283);
            this.BorderLeft.TabIndex = 3;
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.LightGray;
            this.BorderRight.Location = new System.Drawing.Point(663, -2);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(5, 283);
            this.BorderRight.TabIndex = 4;
            // 
            // MessBoxPNL
            // 
            this.MessBoxPNL.BackColor = System.Drawing.Color.CadetBlue;
            this.MessBoxPNL.Controls.Add(this.BorderBottom);
            this.MessBoxPNL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessBoxPNL.Location = new System.Drawing.Point(0, 239);
            this.MessBoxPNL.Name = "MessBoxPNL";
            this.MessBoxPNL.Size = new System.Drawing.Size(668, 42);
            this.MessBoxPNL.TabIndex = 2;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.LightGray;
            this.BorderBottom.Location = new System.Drawing.Point(6, 37);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(662, 5);
            this.BorderBottom.TabIndex = 6;
            // 
            // CustomDoorMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(668, 281);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.MessBoxPNL);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.ChangeFormBT);
            this.Controls.Add(this.WordLB);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDoorMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomDoorMessageBox";
            this.MessBoxPNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordLB;
        private System.Windows.Forms.Button ReturnBT;
        private System.Windows.Forms.Button ChangeFormBT;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel MessBoxPNL;
        private System.Windows.Forms.Panel BorderBottom;
    }
}