using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public partial class UpstairsHallwayForm : Form
    {
        readonly DictionaryUpstairsHallway look = new DictionaryUpstairsHallway();

        public UpstairsHallwayForm()
        {
            InitializeComponent();
        }

        int lanId;
        private int laId;
        public int LanguageId
        {
            get { return lanId; }
            set { lanId = value; }
        }

        private void UpstairsHallwayForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        //private void UpstairsHallwayImgPB(object sender, EventArgs e)
        //{
        //    PictureBox image = sender as PictureBox;
        //    look.Show(image.Name, lanId);
        //}

        private void SelectLanguageBt_Click(object sender, EventArgs e)
        {
            Form1 seLa = new Form1();
            seLa.FormClosing += CloseForm;
            seLa.Show();
            this.Hide();
        }


    }
}
