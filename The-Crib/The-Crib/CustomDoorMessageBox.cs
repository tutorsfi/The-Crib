using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace The_Crib
{
    public partial class CustomDoorMessageBox : Form
    {
        public CustomDoorMessageBox()
        {
            InitializeComponent();
        }
        
        Dictionary<string, string> buttonLibrary = new Dictionary<string, string>()
            {
                {"ReturnBT","return,palaa,UA-r,RUS-r" },
                {"ChangeFormBT","enter,mene,UA-c,RUS-c" }
            };

        public DialogResult ShowDialog(string word, string fiWord, string roomWord, string fiRoom, bool show)
        {
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            OnlyInYardDoorsLB.Text = $"{fiRoom} = {roomWord}";
            OnlyInYardDoorsLB.Visible = show;
            return this.ShowDialog();
        }

        public DialogResult ShowDialog1(string word, string fiWord, int lanId)
        {
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            MessageBoxButtonTexts(lanId);
            return this.ShowDialog();
        }

        private void MessageBoxButtonTexts(int lanId)
        {
            string selectedWord = buttonLibrary["ReturnBT"];//Selecting words for ReturnBT from library by key.
            string selectedWord1 = buttonLibrary["ChangeFormBT"];//Selecting words for room ChangeFormBT
            string[] separators = { "," };//Defining separators for array assigning
            string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
            string[] wordArr1 = selectedWord1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string returnWord = wordArr[lanId];//Selecting ReturnBT word by index.
            string changeWord = wordArr1[lanId];// selecting ChangeFormBT word
            ReturnBT.Text = $"{returnWord}";
            ChangeFormBT.Text = $"{changeWord}";
        }

        
    }
}
