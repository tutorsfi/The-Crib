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
            Dictionary<string, string> leave = new Dictionary<string, string>()
            {
                {"LeaveSaunaPB","bathroom, kylpyhuone"}
            };

            string selectedWord = leave["LeaveSaunaPB"];
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
                BathroomForm bathroom = new BathroomForm();
                bathroom.FormClosing += CloseForm;
                bathroom.LanguageId = lanId;
                bathroom.Show();
                this.Hide();
            }
        }
    }
}
