using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public partial class WcForm : Form
    {
        readonly DictionaryWC look = new DictionaryWC();

        public WcForm()
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


        private void WcForm_Load(object sender, EventArgs e)
        {
            lanId = laId; // passing the language id to this form
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ToiletImgPB(object sender, EventArgs e)
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

        private void WcDoorPB_Click(object sender, EventArgs e)
        {
            bool show = true;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() // words to show when the wc door is clicked
            {
                {"WcDoorPB","a door,ovi,двері,дверь"},
                {"room","a hallway,eteinen,word,word"}
            };
            string selectedWord = doorLibrary["WcDoorPB"]; // selecting the words from the library 
            string roomWord = doorLibrary["room"];
            string[] separators = { "," }; // defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId]; // selecting the right word for the label
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox(); // custom messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show); // selecting the words for the custom messagebox
            if (result == DialogResult.OK) // if OK is clicked, the messagebox closes
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes) // if YES is clicked, the messagebox closes and opens a new form
            {
                UpstairsHallwayForm hallway = new UpstairsHallwayForm(); // EDIT when hallwayform is available
                hallway.FormClosing += CloseForm;
                hallway.LanguageId = lanId;
                hallway.Show();
                this.Hide();
            }
        }

        
    }
}
