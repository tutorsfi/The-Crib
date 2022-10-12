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
/// Code for upstairshallway-form. Unfinished, needs work with translations and commenting.
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
            get { return lanId; }
            set { lanId = value; }
        }

        private void UpstairsHallwayForm_Load(object sender, EventArgs e)
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

        private void BathroomDoorPB_Click(object sender, EventArgs e)
        {
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"BathroomDoorPB","a door,ovi,двері,дверь"},
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
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show);
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
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"KidsRoomDoorPB","a door,ovi,двері,дверь"},
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
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show);
           
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
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"BedroomDoorPB","a door,ovi,двері,дверь"},
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
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show);

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
            bool show = true;
            Dictionary<string, string> doorlibrary = new Dictionary<string, string>()
            {
                {"StudyDoorPB","a door,ovi,двері,дверь"},
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
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show);

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
    }
}
