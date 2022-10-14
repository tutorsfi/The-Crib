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
    public partial class DiningRoomForm : Form
    {
        readonly DictionaryDiningRoom look = new DictionaryDiningRoom();

        public DiningRoomForm()
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

        private void DiningRoomForm_Load(object sender, EventArgs e)
        {
            lanId = laId; // passing the language id to this form
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }


        private void DiningRoomImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox; // when any image is clicked, it will call the class 
            look.Show(image.Name, lanId);
        }

        private void CabinetPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() // words to show when the sauna door is clicked
            {
                {"CabinetPB","a cabinet,vitriini,шафа,шкаф"},
                {"room","room,room,room,room"}
            };

            string selectedWord = doorLibrary["CabinetPB"]; // selecting the words from the library 
            string roomWord = doorLibrary["room"];
            string[] separators = { "," }; // defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string[] roomArr = roomWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string room = roomArr[lanId]; // selecting the right word for the label
            string fiRoom = roomArr[1];
            string word = wordArr[lanId];
            string fiWord = wordArr[1];
            CustomDoorMessageBox CustMessageBox = new CustomDoorMessageBox(); // custom messagebox
            DialogResult result = CustMessageBox.ShowDialog(word, fiWord, room, fiRoom, show, lanId); // selecting the words for the custom messagebox
            if (result == DialogResult.OK) // if OK is clicked, the messagebox closes
            {
                CustMessageBox.Close();
            }
            else if (result == DialogResult.Yes) // if YES is clicked, the messagebox closes and opens a new form
            {
                CabinetForm cabinet = new CabinetForm();
                cabinet.LanguageId = lanId;
                cabinet.Show();
                
            }
        }

        private void ToKitchenPB_Click(object sender, EventArgs e)
        {

        }
    }
}
