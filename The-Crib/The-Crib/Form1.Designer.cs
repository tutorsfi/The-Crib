namespace The_Crib
{
    partial class Form1
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
            this.UkrainianLaBT = new System.Windows.Forms.Button();
            this.RussianLaBT = new System.Windows.Forms.Button();
            this.NextFormBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UkrainianLaBT
            // 
            this.UkrainianLaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UkrainianLaBT.Location = new System.Drawing.Point(424, 301);
            this.UkrainianLaBT.Margin = new System.Windows.Forms.Padding(2);
            this.UkrainianLaBT.Name = "UkrainianLaBT";
            this.UkrainianLaBT.Size = new System.Drawing.Size(194, 78);
            this.UkrainianLaBT.TabIndex = 0;
            this.UkrainianLaBT.Text = "UA";
            this.UkrainianLaBT.UseVisualStyleBackColor = true;
            this.UkrainianLaBT.Click += new System.EventHandler(this.UkrainianLaBT_Click);
            // 
            // RussianLaBT
            // 
            this.RussianLaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RussianLaBT.Location = new System.Drawing.Point(725, 301);
            this.RussianLaBT.Margin = new System.Windows.Forms.Padding(2);
            this.RussianLaBT.Name = "RussianLaBT";
            this.RussianLaBT.Size = new System.Drawing.Size(206, 78);
            this.RussianLaBT.TabIndex = 1;
            this.RussianLaBT.Text = "RUS";
            this.RussianLaBT.UseVisualStyleBackColor = true;
            this.RussianLaBT.Click += new System.EventHandler(this.RussianLaBT_Click);
            // 
            // NextFormBT
            // 
            this.NextFormBT.Location = new System.Drawing.Point(550, 488);
            this.NextFormBT.Margin = new System.Windows.Forms.Padding(2);
            this.NextFormBT.Name = "NextFormBT";
            this.NextFormBT.Size = new System.Drawing.Size(84, 36);
            this.NextFormBT.TabIndex = 2;
            this.NextFormBT.Text = "Next form";
            this.NextFormBT.UseVisualStyleBackColor = true;
            this.NextFormBT.Visible = false;
            this.NextFormBT.Click += new System.EventHandler(this.NextFormBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.NextFormBT);
            this.Controls.Add(this.RussianLaBT);
            this.Controls.Add(this.UkrainianLaBT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UkrainianLaBT;
        private System.Windows.Forms.Button RussianLaBT;
        private System.Windows.Forms.Button NextFormBT;
    }
}

