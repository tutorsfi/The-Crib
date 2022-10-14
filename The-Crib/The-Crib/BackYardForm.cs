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
/// Backyard view. Unfinished.  New messagebox attached to door. Quick tests in demo doesn't work if code is in class so
/// now code is in DoorPB_click - method.
///</summary>
namespace The_Crib
{
    public partial class BackYardForm : Form
    {
        DictionaryBackyard diBaYa = new DictionaryBackyard(); //variable for class where words are
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public BackYardForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void BackYardForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }

        private void DoorPB_Click(object sender, EventArgs e)
        {
            bool show = true; // boolean for outdoors to show label where is translation for door
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
        {
                {"DoorPB", "a door,ovi,двері,дверь" },// Words for door
                {"room","a living room,olohuone,Вітальня,гостиная" }// need to verify.
        };
            string selectedWord = doorLibrary["DoorPB"];//Selecting words for picture from library by key.
            string roomWord = doorLibrary["room"];//Selecting words for room
            string[] separators = { "," };//Defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];// selecting room words
            string fiRoom = roomArr[1];// fi room name
            string word = wordArr[lanId];//Selecting right word for picture by index.
            string fiWord = wordArr[1];// variable for finnish word
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();// variable for custom message box
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId); // calling "message box"
            if (result == DialogResult.OK)// clicked button in message box for returning to current page
            {
                CustMessageBox.Close(); // closing messagebox
            }
            else if (result == DialogResult.Yes)// clicked button in messagebox for change of room
            {
                MainMenuForm frYaFo = new MainMenuForm(); // FrontYardForm 
                frYaFo.FormClosing += CloseForm; //
                frYaFo.LanguageId = laId; // passing id to another form
                frYaFo.Show(); // opening next form
                this.Hide(); // hiding this one

            }
        }

        private void HousePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void WindowDRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void WindowSRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void WindowKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void RoofPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void SwingPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void TerracePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void OutdoorChairPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void OutdoorTablePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void RakePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void BroomPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void ToyShovelPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }

        private void ToyBucketPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diBaYa.Show(image.Name, lanId);
        }
    }
}
