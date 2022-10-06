using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 5.10.2022
/// <summary>
/// Front yard view. Unfinished. New messagebox attached to door. Quick tests in demo doesn't work if code is in class so
/// now code is in DoorPB_click - method.
///</summary>

namespace The_Crib
{
    public partial class FrontYardForm : Form
    {
        DictionaryFrontYard diFrYa = new DictionaryFrontYard(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public FrontYardForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void FrontYardForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }

        private void HousePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void DoorPB_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
        {
                {"DoorPB", "a door,ovi,двері,дверь" }// Words for door
        };
            string selectedWord = doorLibrary["DoorPB"];//Selecting words for picture from library by key.
            string[] separators = { "," };//Defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
            string word = wordArr[lanId];//Selecting right word for picture by index.
            string fiWord = wordArr[0];// variable for finnish word
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();// variable for custom message box
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord); // calling "message box"
            if (result == DialogResult.OK)// clicked button in message box for returning to current page
            {
                CustMessageBox.Close(); // closing messagebox
            }
            else if (result == DialogResult.Yes)// clicked button in messagebox for change of room
            {
                BackYardForm baYaFo = new BackYardForm();//room where door leads
                baYaFo.FormClosing += CloseForm;// call CloseForm method
                baYaFo.LanguageId = laId; // passing id to another form
                baYaFo.Show();
                this.Hide();

            }
        }

        private void BushPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void TreePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void RoofPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowKiPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowMasBedPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowBathroomPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowWcPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }
    }
}
