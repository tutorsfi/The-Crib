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
/// version 17.10.2022
/// <summary>
/// Living room view. Door to hallway and backyard, uses own messagebox because messagebox styling requirements and code to assiqn words to messagebox is writen here because it need to operate
/// form change and it was easier to write code here than dictionary class which operates pictures translation viewing method.
///</summary>
namespace The_Crib
{
    public partial class LivingRoomForm : Form
    {
        DictionaryLivingRoom diLIRo = new DictionaryLivingRoom(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public LivingRoomForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void LivingRoomForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }

        private void CouchPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void CoffeeTablePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void TelevisionPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void TvStandPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void WindowPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void RemoteControlPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void GameConsolPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void GameControllerPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void CurtainsPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void DoorToHallwayPB_Click(object sender, EventArgs e)
        {
            try
            {
                bool show = false; // boolean for outdoors to show label where is translation for door
                Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
                {
                        {"DoorPB", "a hallway,käytävä,коридор,прихожая" },// Words for door
                        {"room", "a door,ovi,двері,дверь" }// need to verify.
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
                    HallwayForm haWaFo = new HallwayForm();//room where door leads
                    haWaFo.FormClosing += CloseForm;// call CloseForm method
                    haWaFo.LanguageId = laId; // passing id to another form
                    haWaFo.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoorToBackyard_Click(object sender, EventArgs e)
        {
            try
            {
                bool show = true; // boolean for outdoors to show label where is translation for door
                Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
                {
                        {"DoorPB", "a door,ovi,двері,дверь" },// Words for door
                        {"room", "a backyard,takapiha,задній двір,задний двор" }// need to verify.
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
                    BackYardForm baYaFo = new BackYardForm();//room where door leads
                    baYaFo.FormClosing += CloseForm;// call CloseForm method
                    baYaFo.LanguageId = laId; // passing id to another form
                    baYaFo.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LanguageSelectionBT_Click(object sender, EventArgs e) // redirecting to language selection Form1
        {
            Form1 laSe = new Form1();
            laSe.FormClosing += CloseForm;
            laSe.Show();
            this.Hide();
        }

        private void MagazinePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void NewspaperPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void FlowerTablePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void FlowersPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void BlanketPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }

        private void DecorativePillowPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diLIRo.Show(image.Name, lanId);
        }
    }
}
