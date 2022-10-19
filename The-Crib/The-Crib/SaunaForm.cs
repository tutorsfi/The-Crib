using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Author@ Karoliina Salo
/// Version 12.10.2022
/// <summary>
/// Code for sauna-form. Unfinished, needs work with translations and commenting.
/// </summary>

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
            get { return laId; }
            set { laId = value; }
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
            try
            {
                Dictionary<string, string> arrowLibrary = new Dictionary<string, string>()
                {
                        {"LeaveSaunaPB", "a bathroom,kylpyhuone,word,word"}
                };
                string selectedWord = arrowLibrary["LeaveSaunaPB"];//Selecting words for picture from library by key.
                string[] separators = { "," };//Defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
                string word = wordArr[lanId];//Selecting right word for picture by index.
                string fiWord = wordArr[1];// variable for finnish word
                CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();// variable for custom message box
                DialogResult result = CustMessageBox.ShowDialog1(word, fiWord, lanId); // calling "message box"
                if (result == DialogResult.OK)// clicked button in message box for returning to current page
                {
                    CustMessageBox.Close(); // closing messagebox
                }
                else if (result == DialogResult.Yes)// clicked button in messagebox for change of room
                {
                    BathroomForm bathroom = new BathroomForm(); //room where door leads
                    bathroom.FormClosing += CloseForm;// call CloseForm method
                    bathroom.LanguageId = laId; // passing id to another form
                    bathroom.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
