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
    public partial class CreditsForm : Form
    {
        int lanId; // variable for language-id
        private int laId; // private declaration for get/set
        public int LanguageId // get/set -definition
        {
            get { return laId; }
            set { laId = value; }
        }

        public CreditsForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e) // to close the current form
        {
            this.Close();
        }


        private void CreditsForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
            Dictionary<string,string> credits = new Dictionary<string,string>() // dictionary to store all the words
            {
                {"CreditsLB","Credits,Tekijät,Word,Word"},
                {"ProgrammingLB","Programming,Ohjelmoijat,Word,Word"},
                {"GraphicsLB","Graphics,Grafiikat,Word,Word"}
            };

            string creditsWord = credits["CreditsLB"]; // selecting words from the library for CreditsLB
            string[] separators = { "," }; // defining separators for array assigning
            string[] wordArr = creditsWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string credWord = wordArr[lanId]; // selecting the right word for the label
            CreditsLB.Text = credWord; // passing the selected word for the label

            string programWord = credits["ProgrammingLB"]; // selecting words from the library for ProgrammingLB
            string[] wordArr1 = programWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string pgrmWord = wordArr1[lanId]; // selecting the right word for the label
            ProgrammingLB.Text = pgrmWord; // passing the selected word for the label

            string graphsWord = credits["GraphicsLB"]; // selecting words from the library for GraphicsLB
            string[] wordArr2 = graphsWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
            string graphWord = wordArr2[lanId]; // selecting the right word for the label
            GraphicsLB.Text = graphWord; // passing the selected word for the label

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainmenu = new MainMenuForm(); // opening the MainMenuForm
            mainmenu.FormClosing += CloseForm; // closing the current form while opening the new one
            mainmenu.LanguageId = laId; // passing the language id to next form
            mainmenu.Show(); // showing the new form
            this.Hide(); // hiding the current form
        }
    }
}
