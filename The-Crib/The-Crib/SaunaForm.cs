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
    public partial class SaunaForm : Form
    {
        readonly DictionarySauna look = new DictionarySauna();
        public SaunaForm()
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


        private void SaunaForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void SelectLanguageBt_Click(object sender, EventArgs e)
        {
            Form1 seLa = new Form1();
            seLa.FormClosing += CloseForm;
            seLa.Show();
            this.Hide();
        }

        private void SaunaImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            look.Show(image.Name, lanId);
        }

        private void LeaveSaunaPB_Click(object sender, EventArgs e)
        {
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"LeaveSaunaPB","return,takaisin,word,word"},
                {"room","a bathroom,kylpyhuone,word,word"}
            };

            string selectedWord = doorLibrary["LeaveSaunaPB"];
            string roomWord = doorLibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord,fiRoom,show);
            if (result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                BathroomForm bathroom = new BathroomForm();
                bathroom.FormClosing += CloseForm;
                bathroom.LanguageId = laId;
                bathroom.Show();
                this.Hide();
            }
        }
    }
}
