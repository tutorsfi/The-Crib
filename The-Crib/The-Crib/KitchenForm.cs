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
/// Version 17.10.2022
/// <summary>
/// Code for the kitchen. Graphics placed by Tuomas Lahdensuu.
/// </summary>

namespace The_Crib
{
    public partial class KitchenForm : Form
    {
        readonly DictionaryKitchen look = new DictionaryKitchen();

        public KitchenForm()
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


        private void KitchenForm_Load(object sender, EventArgs e)
        {
            lanId = laId; // passing the language id to this form
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }


        private void KitchenImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox; // when any image is clicked, it will call the class 
            look.Show(image.Name, lanId);
        }

        private void LeaveKitchenPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>() // words to show when the wc door is clicked
            {
                {"LeaveKitchenPB","a hallway,eteinen,word,word"},
                {"room","a hallway,eteinen,word,word"}
            };
            string selectedWord = doorLibrary["LeaveKitchenPB"]; // selecting the words from the library 
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
                HallwayForm hallway = new HallwayForm();
                hallway.FormClosing += CloseForm;
                hallway.LanguageId = lanId;
                hallway.Show();
                this.Hide();
            }
        }

        private void DrawerKPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"DrawerKPB", "a drawer,vetolaatikko,шухляда,выдвижной ящик"},
                {"room","word,word,word,word"}
            };
            string selectedWord = doorLibrary["DrawerKPB"];
            string roomWord = doorLibrary["room"];
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
            else if (result == DialogResult.Yes)    // open the drawer
            {
                DrawerForm drawer = new DrawerForm();  // form that opens
                drawer.LanguageId = laId;  // passing lang id to other form
                drawer.Show();


            }
        }

        private void FridgeKPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"FridgeKPB", "a fridge,jääkaappi,холодильник,холодильник"},
                {"room","word,word,word,word"}
            };
            string selectedWord = doorLibrary["FridgeKPB"];
            string roomWord = doorLibrary["room"];
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
            else if (result == DialogResult.Yes)    // open the fridge
            {
                FridgeForm fridge = new FridgeForm();  // form that opens
                fridge.LanguageId = laId;  // passing lang id to other form
                fridge.Show();


            }
        }

        private void FreezerKPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"FreezerKPB", "a freezer,pakastin,морозильна камера,морозильна камера"},
                {"room","word,word,word,word"}
            };
            string selectedWord = doorLibrary["FreezerKPB"];
            string roomWord = doorLibrary["room"];
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
            else if (result == DialogResult.Yes)    // open freezer
            {
                FreezerForm freezer = new FreezerForm(); // form that opens
                freezer.LanguageId = laId;  // passing lang id to other form
                freezer.Show();


            }

        }

        private void CabinetDoorsPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"CabinetDoorsPB", "a cabinet,kaappi,word,word"},
                {"room","word,word,word,word"}
            };
            string selectedWord = doorLibrary["CabinetDoorsPB"];
            string roomWord = doorLibrary["room"];
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
            else if (result == DialogResult.Yes)    // open the cabinet
            {
                LowerCabinetForm lowerCabinet = new LowerCabinetForm();  // form that opens
                lowerCabinet.LanguageId = laId;  // passing lang id to other form
                lowerCabinet.Show();


            }
        }

        private void DryingCabinetKPB_Click(object sender, EventArgs e)
        {
            bool show = false;
            Dictionary<string, string> doorLibrary = new Dictionary<string, string>()
            {
                {"DryingCabinetKPB", "a drying cabinet,kuivauskaappi,word,word"},
                {"room","word,word,word,word"}
            };
            string selectedWord = doorLibrary["DryingCabinetKPB"];
            string roomWord = doorLibrary["room"];
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
            else if (result == DialogResult.Yes)    // open the cabinet
            {
                DryingCabinetForm dryingCabinet = new DryingCabinetForm();  // form that opens
                dryingCabinet.LanguageId = laId;  // passing lang id to other form
                dryingCabinet.Show();


            }
        }

        private void EnterDiningRoomPB_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> arrowLibrary = new Dictionary<string, string>()
                {
                        {"EnterDiningRoomPB", "a dining room,ruokailutila,word,word"}
                };
                string selectedWord = arrowLibrary["EnterDiningRoomPB"];//Selecting words for picture from library by key.
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
                    DiningRoomForm diningRoom = new DiningRoomForm(); //room where door leads
                    diningRoom.FormClosing += CloseForm;// call CloseForm method
                    diningRoom.LanguageId = laId; // passing id to another form
                    diningRoom.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
