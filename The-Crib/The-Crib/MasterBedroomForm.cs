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
/// version 10.10.2022
/// <summary>
/// Master bedroom view. Finished.
///</summary>

namespace The_Crib
{
    public partial class MasterBedroomForm : Form
    {
        DictionaryMasterBedroom dimaBr = new DictionaryMasterBedroom(); //variable for class where words are 
        
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public MasterBedroomForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ceilingLampMBPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            dimaBr.Show(image.Name, lanId);
        }

        private void MasterBedroomForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }

        private void WardrobeMBPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
               {"wardrobeMBPB", "a wardrobe,vaatekaappi,шафа для одягу,шкаф для одежды" },  // EN - FI - UA - RU
                {"room","hallway,käytävä,коридор,прихожая" } //ua needs checking
        };
            string selectedWord = doorDic["wardrobeMBPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[0];
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
                MasterBedroomWardrobeForm bdrm = new MasterBedroomWardrobeForm();    //room the door leads to
                bdrm.LanguageId = laId;  // passing lang id to other form
                bdrm.Show();

            }
        }

        private void bedMBPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            dimaBr.Show(image.Name, lanId);
        }

        private void bedspreadMBPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            dimaBr.Show(image.Name, lanId);
        }

        private void doorBRPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"DoorMBPB", "a door,ovi,двері,дверь" },    // EN - FI - UA - RU
                {"room","a living room,olohuone,Вітальня,гостиная" }
        };
            string selectedWord = doorDic["DoorMBPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[0];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[0];
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

        private void langBtnMB_Click(object sender, EventArgs e)
        {
            Form1 langMenu = new Form1();    //room the door leads to
            langMenu.FormClosing += CloseForm;   // call CloseForm method
            langMenu.Show();
            this.Hide();
        }

        private void nightstandMBPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            dimaBr.Show(image.Name, lanId);
        }
    }
}
