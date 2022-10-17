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
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> buttonLibrary = new Dictionary<string, string>()
            {
                {"ReturnBT","return,palaa,UA-r,RUS-r" }
            };
        public DialogResult ShowDialog(string word, string fiWord, int lanId)
        {
            string selectedWord = buttonLibrary["ReturnBT"];//Selecting words for ReturnBT from library by key.
            string[] separators = { "," };//Defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
            string returnWord = wordArr[lanId];//Selecting ReturnBT word by index.
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            ReturnBT.Text = $"{returnWord}";
            return this.ShowDialog();
        }
    }
}
