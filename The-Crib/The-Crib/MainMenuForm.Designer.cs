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
            this.StartGameBT.Location = new System.Drawing.Point(892, 358);
            this.StartGameBT.Name = "StartGameBT";
            this.StartGameBT.Size = new System.Drawing.Size(137, 58);
            this.StartGameBT.TabIndex = 0;
            this.StartGameBT.Text = "Start game";
            this.StartGameBT.UseVisualStyleBackColor = true;
            this.StartGameBT.Click += new System.EventHandler(this.StartGameBT_Click);
            // 
            // CreditsBT
            // 
            this.CreditsBT.Location = new System.Drawing.Point(892, 490);
            this.CreditsBT.Name = "CreditsBT";
            this.CreditsBT.Size = new System.Drawing.Size(137, 59);
            this.CreditsBT.TabIndex = 1;
            this.CreditsBT.Text = "Credits";
            this.CreditsBT.UseVisualStyleBackColor = true;
            this.CreditsBT.Click += new System.EventHandler(this.CreditsBT_Click);
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 883);
            this.Controls.Add(this.CreditsBT);
            this.Controls.Add(this.StartGameBT);
            this.Name = "StartGameForm";
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