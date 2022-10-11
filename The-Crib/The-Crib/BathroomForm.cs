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
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() 
            {
                {"SaunaDoorPB","a door,ovi,двері,дверь"},
                {"room","a sauna, sauna,word,word"}
            };

            string selectedWord = doorLibrary["SaunaDoorPB"];
            string roomWord = doorLibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show);
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
            bool show = true;
            Dictionary<string, string> leave = new Dictionary<string, string>()
            {
                {"BathroomLeavePB","a door,ovi,двері,дверь"},
                {"room","upstairs hallway, yläkerran käytävä,word,word"}
            };

            string selectedWord = leave["BathroomLeavePB"];
            string roomWord = leave["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show);
            if (result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                UpstairsHallwayForm upstairs = new UpstairsHallwayForm();
                upstairs.FormClosing += CloseForm;
                upstairs.LanguageId = laId;
                upstairs.Show();
                this.Hide();
            }

        }
    }
}
