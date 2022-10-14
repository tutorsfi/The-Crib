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
/// Study room view. Unfinished. There are no graphics for this room´s objects yet.
///</summary>

namespace The_Crib
{
    public partial class StudyForm : Form
    {

        DictionaryStudyRoom study = new DictionaryStudyRoom(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public StudyForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void deskSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void laptopSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void chairSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void calendarSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void phoneSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void notebookSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void penSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void desklampSTRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void bookshelfSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void extensionCordSTPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            study.Show(image.Name, lanId);
        }

        private void doorSTPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorDic = new Dictionary<string, string>()
        {
                {"DoorSTPB", "a door,ovi,двері,дверь" },    // EN - FI - UA - RU
                {"room","hallway,käytävä,коридор,прихожая" } //ua needs checking
        };
            string selectedWord = doorDic["DoorSTPB"];
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
    }
}
