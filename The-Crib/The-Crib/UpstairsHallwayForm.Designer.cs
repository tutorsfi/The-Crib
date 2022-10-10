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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpstairsHallwayForm));
            this.SelectLanguageBt = new System.Windows.Forms.Button();
            this.BathroomDoorPB = new System.Windows.Forms.PictureBox();
            this.KidsRoomDoorPB = new System.Windows.Forms.PictureBox();
            this.BedroomDoorPB = new System.Windows.Forms.PictureBox();
            this.StudyDoorPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomDoorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KidsRoomDoorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomDoorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudyDoorPB)).BeginInit();
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
            // BathroomDoorPB
            // 
            this.BathroomDoorPB.BackColor = System.Drawing.Color.Transparent;
            this.BathroomDoorPB.Image = global::The_Crib.Properties.Resources.Door;
            this.BathroomDoorPB.Location = new System.Drawing.Point(714, 262);
            this.BathroomDoorPB.Name = "BathroomDoorPB";
            this.BathroomDoorPB.Size = new System.Drawing.Size(211, 388);
            this.BathroomDoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BathroomDoorPB.TabIndex = 5;
            this.BathroomDoorPB.TabStop = false;
            this.BathroomDoorPB.Click += new System.EventHandler(this.BathroomDoorPB_Click);
            // 
            // KidsRoomDoorPB
            // 
            this.KidsRoomDoorPB.BackColor = System.Drawing.Color.Transparent;
            this.KidsRoomDoorPB.Image = ((System.Drawing.Image)(resources.GetObject("KidsRoomDoorPB.Image")));
            this.KidsRoomDoorPB.Location = new System.Drawing.Point(160, 225);
            this.KidsRoomDoorPB.Name = "KidsRoomDoorPB";
            this.KidsRoomDoorPB.Size = new System.Drawing.Size(138, 587);
            this.KidsRoomDoorPB.TabIndex = 6;
            this.KidsRoomDoorPB.TabStop = false;
            this.KidsRoomDoorPB.Click += new System.EventHandler(this.KidsRoomDoorPB_Click);
            // 
            // BedroomDoorPB
            // 
            this.BedroomDoorPB.BackColor = System.Drawing.Color.Transparent;
            this.BedroomDoorPB.Image = global::The_Crib.Properties.Resources.DoorToRight;
            this.BedroomDoorPB.Location = new System.Drawing.Point(1314, 211);
            this.BedroomDoorPB.Name = "BedroomDoorPB";
            this.BedroomDoorPB.Size = new System.Drawing.Size(123, 525);
            this.BedroomDoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BedroomDoorPB.TabIndex = 7;
            this.BedroomDoorPB.TabStop = false;
            this.BedroomDoorPB.Click += new System.EventHandler(this.BedroomDoorPB_Click);
            // 
            // StudyDoorPB
            // 
            this.StudyDoorPB.BackColor = System.Drawing.Color.Transparent;
            this.StudyDoorPB.Image = global::The_Crib.Properties.Resources.DoorToRight;
            this.StudyDoorPB.Location = new System.Drawing.Point(1470, 200);
            this.StudyDoorPB.Name = "StudyDoorPB";
            this.StudyDoorPB.Size = new System.Drawing.Size(153, 675);
            this.StudyDoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudyDoorPB.TabIndex = 8;
            this.StudyDoorPB.TabStop = false;
            this.StudyDoorPB.Click += new System.EventHandler(this.StudyDoorPB_Click);
            // 
            // UpstairsHallwayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Crib.Properties.Resources.UpstairsHallway;
            this.ClientSize = new System.Drawing.Size(1634, 891);
            this.Controls.Add(this.StudyDoorPB);
            this.Controls.Add(this.BedroomDoorPB);
            this.Controls.Add(this.KidsRoomDoorPB);
            this.Controls.Add(this.BathroomDoorPB);
            this.Controls.Add(this.SelectLanguageBt);
            this.Name = "UpstairsHallwayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpstairsHallwayForm";
            this.Load += new System.EventHandler(this.UpstairsHallwayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BathroomDoorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KidsRoomDoorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomDoorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudyDoorPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectLanguageBt;
        private System.Windows.Forms.PictureBox BathroomDoorPB;
        private System.Windows.Forms.PictureBox KidsRoomDoorPB;
        private System.Windows.Forms.PictureBox BedroomDoorPB;
        private System.Windows.Forms.PictureBox StudyDoorPB;
    }
}