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

        private void SelectLanguageBt_Click(object sender, EventArgs e)
        {
            Form1 seLa = new Form1(); // shows form1 where the language is selected
            seLa.FormClosing += CloseForm; // closing the current form while opening the new one
            seLa.Show(); // showing the new form
            this.Hide(); // hiding the current form
        }

        private void SaunaDoorPB_Click(object sender, EventArgs e)
        {
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() // words to show when the sauna door is clicked
            {
                {"SaunaDoorPB","a door,ovi,двері,дверь"},
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
            bool show = true;
            Dictionary<string, string> leave = new Dictionary<string, string>() // words to show when the arrow is clicked
            {
                {"BathroomLeavePB","a door,ovi,двері,дверь"},
                {"room","upstairs hallway, yläkerran käytävä,word,word"}
            };

            string selectedWord = leave["BathroomLeavePB"]; // selecting words from the library
            string roomWord = leave["room"];
            string[] separators = { "," }; // defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];// selecting the right word for the label
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox(); // custom messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId); // selecting the words for the custom messagebox
            if (result == DialogResult.OK)// if OK is clicked, the messagebox closes
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes) // if YES is clicked, the messagebox closes and opens a new form
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
