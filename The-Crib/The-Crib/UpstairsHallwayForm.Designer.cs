namespace The_Crib
{
    partial class UpstairsHallwayForm
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
            this.SelectLanguageBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectLanguageBt
            // 
            this.SelectLanguageBt.Location = new System.Drawing.Point(12, 12);
            this.SelectLanguageBt.Name = "SelectLanguageBt";
            this.SelectLanguageBt.Size = new System.Drawing.Size(109, 28);
            this.SelectLanguageBt.TabIndex = 4;
            this.SelectLanguageBt.Text = "Select language";
            this.SelectLanguageBt.UseVisualStyleBackColor = true;
            this.SelectLanguageBt.Click += new System.EventHandler(this.SelectLanguageBt_Click);
            // 
            // UpstairsHallwayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.UpstairsHallway;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.SelectLanguageBt);
            this.Name = "UpstairsHallwayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpstairsHallwayForm";
            this.Load += new System.EventHandler(this.UpstairsHallwayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectLanguageBt;
    }
}