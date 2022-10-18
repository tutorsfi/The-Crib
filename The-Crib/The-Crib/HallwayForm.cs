using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// author@ Jenna Koskelo
/// version 18.10.2022
/// <summary>
/// Downstairs hallway view. Opens to kitchen, living room, toilet and upstairs hallway. Closet has clothes inside. 
/// Doors and stairs placed by Tuomas.
///</summary>

namespace The_Crib
{
    public partial class HallwayForm : Form
    {
        DictionaryHallway hallway = new DictionaryHallway(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public HallwayForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void stairsHWPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"stairsHWPB", "stairs,portaat,сходи,лестница" },    // EN - FI - UA - RU
                {"room","living room,olohuone,Вітальня,гостиная" } // these are not used in this form
        };
            string selectedWord = doorDic["stairsHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                UpstairsHallwayForm hallway = new UpstairsHallwayForm();    //room the door leads to
                hallway.FormClosing += CloseForm;   // call CloseForm method
                hallway.LanguageId = laId;  // passing lang id to other form
                hallway.Show();
                this.Hide();

            }
        }

        private void wcDoorHWPB_Click(object sender, EventArgs e)
        {
            bool show = false; 
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"wcDoorHWPB", "toilet,vessa,туалет,туалет" },    // EN - FI - UA - RU
                {"room","toilet,vessa,туалет,туалет" } // these are not used
        };
            string selectedWord = doorDic["wcDoorHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                WcForm wc = new WcForm();    //room the door leads to
                wc.FormClosing += CloseForm;   // call CloseForm method
                wc.LanguageId = laId;  // passing lang id to other form
                wc.Show();
                this.Hide();

            }
        }

        private void LivingRoomDoorHWPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"LivingRoomDoorHWPB", "livingroom,olohuone,Вітальня,гостиная" },    // EN - FI - UA - RU
                {"room","living room,olohuone,Вітальня,гостиная" } // these ones are not used in this form
        };
            string selectedWord = doorDic["LivingRoomDoorHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                LivingRoomForm lrm = new LivingRoomForm();    //room the door leads to
                lrm.FormClosing += CloseForm;   // call CloseForm method
                lrm.LanguageId = laId;  // passing lang id to other form
                lrm.Show();
                this.Hide();

            }
        }

        private void KitchenDoorHWPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"KitchenDoorHWPB", "kitchen,keittiö,кухня,кухня" },    // EN - FI - UA - RU
                {"room","living room,olohuone,Вітальня,гостиная" } // these ones are not used in this form
        };
            string selectedWord = doorDic["KitchenDoorHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                KitchenForm kitchen = new KitchenForm();    //room the door leads to
                kitchen.FormClosing += CloseForm;   // call CloseForm method
                kitchen.LanguageId = laId;  // passing lang id to other form
                kitchen.Show();
                this.Hide();

            }
        }

        private void closetHWPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
               {"closetHWPB", "a closet,kaappi,шафа,шкаф"},  // EN - FI - UA - RU
               {"room","hallway,käytävä,коридор,прихожая" } //not used in this form
        };
            string selectedWord = doorDic["closetHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                HallwayClosetForm closet = new HallwayClosetForm();    //room the door leads to
                closet.LanguageId = laId;  // passing lang id to other form
                closet.Show();

            }
        }

        private void plantHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void rugHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void arrowHWPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
               {"arrowHWPB", "front yard,etupiha,Передній двір,передний двор"},  // EN - FI - UA - RU
               {"room","hallway,käytävä,коридор,прихожая" } //not used in this form
        };
            string selectedWord = doorDic["arrowHWPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show, lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                FrontYardForm yard = new FrontYardForm();    //room the door leads to
                yard.LanguageId = laId;  // passing lang id to other form
                yard.Show();

            }
        }

        private void HallwayForm_Load(object sender, EventArgs e)
        {
            lanId = lanId;
        }
    }
}
