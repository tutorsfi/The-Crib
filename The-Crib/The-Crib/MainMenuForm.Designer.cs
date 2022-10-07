namespace The_Crib
{
    partial class MainMenuForm
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
            this.StartGameBT = new System.Windows.Forms.Button();
            this.CreditsBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameBT
            // 
            this.StartGameBT.Location = new System.Drawing.Point(669, 291);
            this.StartGameBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartGameBT.Name = "StartGameBT";
            this.StartGameBT.Size = new System.Drawing.Size(103, 47);
            this.StartGameBT.TabIndex = 0;
            this.StartGameBT.Text = "Start game";
            this.StartGameBT.UseVisualStyleBackColor = true;
            this.StartGameBT.Click += new System.EventHandler(this.StartGameBT_Click);
            // 
            // CreditsBT
            // 
            this.CreditsBT.Location = new System.Drawing.Point(669, 398);
            this.CreditsBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreditsBT.Name = "CreditsBT";
            this.CreditsBT.Size = new System.Drawing.Size(103, 48);
            this.CreditsBT.TabIndex = 1;
            this.CreditsBT.Text = "Credits";
            this.CreditsBT.UseVisualStyleBackColor = true;
            this.CreditsBT.Click += new System.EventHandler(this.CreditsBT_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.CreditsBT);
            this.Controls.Add(this.StartGameBT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartGameForm";
            this.Load += new System.EventHandler(this.StartGameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameBT;
        private System.Windows.Forms.Button CreditsBT;
    }
}