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
/// Code for upstairshallway-form. Unfinished, needs work with translations and commenting. Need to update where downstairs-arrow takes.
/// </summary>

namespace The_Crib
{
    public partial class UpstairsHallwayForm : Form
    {
        readonly DictionaryUpstairsHallway look = new DictionaryUpstairsHallway();

        public UpstairsHallwayForm()
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

        private void UpstairsHallwayForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }


        private void BathroomDoorPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"BathroomDoorPB","a bathroom, kylpyhuone,word,word"},
                {"room","a bathroom, kylpyhuone,word,word"}
            };

            string selectedWord = doorLibrary["BathroomDoorPB"];
            string roomWord = doorLibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId);
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

        private void KidsRoomDoorPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"KidsRoomDoorPB","a kid's room,lastenhuone,word,word"},
                {"room","a kid's room,lastenhuone,word,word"}
            };

            string selectedWord = doorLibrary["KidsRoomDoorPB"];
            string roomWord = doorLibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show,lanId);
           
            if(result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                KidsRoomForm kidsRoom = new KidsRoomForm();
                kidsRoom.FormClosing += CloseForm;
                kidsRoom.LanguageId = lanId;
                kidsRoom.Show();
                this.Hide();
            }

        }

        private void BedroomDoorPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"BedroomDoorPB","a bedroom, makuuhuone,word,word"},
                {"room","a bedroom, makuuhuone,word,word"}
            };

            string selectedWord = doorLibrary["BedroomDoorPB"];
            string roomWord = doorLibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId);

            if(result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if(result == DialogResult.Yes)
            {
                MasterBedroomForm masterBedroom = new MasterBedroomForm();
                masterBedroom.FormClosing += CloseForm;
                masterBedroom.LanguageId = lanId;
                masterBedroom.Show();
                this.Hide();
            }
        }

        private void StudyDoorPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorlibrary = new Dictionary<string, string>()
            {
                {"StudyDoorPB","a study, työhuone,word,word"},
                {"room","a study, työhuone,word,word"}
            };

            string selectedWord = doorlibrary["StudyDoorPB"];
            string roomWord = doorlibrary["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId);

            if (result == DialogResult.OK)
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)
            {
                StudyForm study = new StudyForm();
                study.FormClosing += CloseForm;
                study.LanguageId = lanId;
                study.Show();
                this.Hide();
            }


        }

        private void ToDownStairsPB_Click(object sender, EventArgs e)
        {

            try
            {
                Dictionary<string, string> arrowLibrary = new Dictionary<string, string>()
                {
                    {"ToDownStairsPB","downstairs,alakerta,word,word" }
                };
                string selectedWord = arrowLibrary["ToDownStairsPB"];//Selecting words for picture from library by key.
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
                    HallwayForm hallway = new HallwayForm(); //room where door leads
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
