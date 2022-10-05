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
            this.SuspendLayout();
            // 
            // WordLB
            // 
            this.WordLB.AutoSize = true;
            this.WordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLB.Location = new System.Drawing.Point(456, 193);
            this.WordLB.Name = "WordLB";
            this.WordLB.Size = new System.Drawing.Size(86, 31);
            this.WordLB.TabIndex = 0;
            this.WordLB.Text = "label1";
            // 
            // ReturnBT
            // 
            this.ReturnBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReturnBT.Location = new System.Drawing.Point(445, 289);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(97, 35);
            this.ReturnBT.TabIndex = 1;
            this.ReturnBT.Text = "Return";
            this.ReturnBT.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1061, 533);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.WordLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomMessageBoxForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordLB;
        private System.Windows.Forms.Button ReturnBT;
    }
}