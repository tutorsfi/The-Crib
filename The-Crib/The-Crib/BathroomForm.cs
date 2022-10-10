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
    public partial class BathroomForm : Form
    {
        readonly DictionaryBathroom look = new DictionaryBathroom();
        public BathroomForm()
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

        private void BathroomForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }
        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void BathroomImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            look.Show(image.Name, lanId);

        }

        private void SelectLanguageBt_Click(object sender, EventArgs e)
        {
            Form1 seLa = new Form1();
            seLa.FormClosing += CloseForm;
            seLa.Show();
            this.Hide();
        }

        private void SaunaDoorPB_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() 
            {
                {"SaunaDoorPB","sauna door, saunan ovi,sana,sana"}
            };

            string selectedWord = doorLibrary["SaunaDoorPB"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord);
            if (result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                SaunaForm Sauna = new SaunaForm();
                Sauna.FormClosing += CloseForm;
                Sauna.LanguageId = lanId;
                Sauna.Show();
                this.Hide();
            }
        }

        private void BathroomLeavePB_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> leave = new Dictionary<string, string>()
            {
                {"BathroomLeavePB","upstairs hallway, yläkerran käytävä"}
            };

            string selectedWord = leave["BathroomLeavePB"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word,fiWord);
            if(result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                UpstairsHallwayForm upHallway = new UpstairsHallwayForm();
                upHallway.FormClosing += CloseForm;
                upHallway.LanguageId = lanId;
                upHallway.Show();
                this.Hide();
            }

        }
    }
}
