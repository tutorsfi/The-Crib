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
/// version 7.10.2022
/// <summary>
/// Kids room view. Unfinished. There are no graphics for this room´s objects yet.
///</summary>

namespace The_Crib
{
    public partial class KidsRoomForm : Form
    {

        DictionaryKidsRoom kids = new DictionaryKidsRoom(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public KidsRoomForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void kidsBedKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void duvetKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void dollKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void pillowKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void teddyKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void bunnyKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void catKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void dogKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void toyCubesKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void toyCarKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void doorKRPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"DoorKRPB", "a door,ovi,двері,дверь" },    // EN - FI - UA - RU
                {"room","hallway,käytävä,коридор,прихожая" } //ua needs checking
        };
            string selectedWord = doorDic["DoorKRPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[0];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[0];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show,lanId);
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

        private void wardrobeKRPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"wardrobeKRPB", "a wardrobe,vaatekaappi,шафа для одягу,шкаф для одежды" },    // EN - FI - UA - RU
                {"room","hallway,käytävä,коридор,прихожая" } //ua needs checking
        };
            string selectedWord = doorDic["wardrobeKRPB"];
            string roomWord = doorDic["room"];
            string[] separators = { "," };
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId];
            string fiRoom = roomArr[0];
            string word = wordArr[lanId];   //Selecting right word by lang index
            string fiWord = wordArr[0];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox();   //new door messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, roomWord, fiRoom, show,lanId);
            if (result == DialogResult.OK)  //return to current form 
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes)    // move to next rooom
            {
                KidsWardrobeForm wardrobe = new KidsWardrobeForm();    //room the door leads to
                wardrobe.FormClosing += CloseForm;   // call CloseForm method
                wardrobe.LanguageId = laId;  // passing lang id to other form
                wardrobe.Show();
                //this.Hide();

            }
        }
    }
}
