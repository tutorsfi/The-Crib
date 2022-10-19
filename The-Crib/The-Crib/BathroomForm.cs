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
/// Code for bathroom-form. Unfinished, needs work with translations
/// </summary>

namespace The_Crib
{
    public partial class BathroomForm : Form
    {
        readonly DictionaryBathroom look = new DictionaryBathroom();
        public BathroomForm()
        {
            InitializeComponent();
        }

        int lanId; // variable for language-id
        private int laId; // private declaration for get/set
        public int LanguageId // get/set -definition
        {
            get { return laId; }
            set { laId = value; }
        }

        private void BathroomForm_Load_1(object sender, EventArgs e)
        {
            lanId = laId; // passing the language id to this form
        }
        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void BathroomImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox; // when any image is clicked, it will call the class 
            look.Show(image.Name, lanId);

        }


        private void SaunaDoorPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() // words to show when the sauna door is clicked
            {
                {"SaunaDoorPB","a sauna,sauna,word,word"},
                {"room","a sauna,sauna,word,word"}
            };

            string selectedWord = doorLibrary["SaunaDoorPB"]; // selecting the words from the library 
            string roomWord = doorLibrary["room"];
            string[] separators = { "," }; // defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId]; // selecting the right word for the label
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox(); // custom messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show,lanId); // selecting the words for the custom messagebox
            if (result == DialogResult.OK) // if OK is clicked, the messagebox closes
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes) // if YES is clicked, the messagebox closes and opens a new form
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
            try
            {
                Dictionary<string, string> arrowLibrary = new Dictionary<string, string>()
                {
                        {"BathroomLeavePB", "a hallway,käytävä,word,word"}
                };
                string selectedWord = arrowLibrary["BathroomLeavePB"];//Selecting words for picture from library by key.
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
                    UpstairsHallwayForm hallway = new UpstairsHallwayForm(); //room where door leads
                    hallway.FormClosing += CloseForm;// call CloseForm method
                    hallway.LanguageId = laId; // passing id to another form
                    hallway.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void langBtnMB_Click(object sender, EventArgs e)
        {
            Form1 seLa = new Form1();
            seLa.FormClosing += CloseForm;
            seLa.Show();
            this.Hide();
        }
    }
}
