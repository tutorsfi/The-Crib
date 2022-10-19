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
/// author@ Antti Kuusisto
/// version 17.10.2022
/// <summary>
/// Form that behaves like messagebox and is used to show words and two buttons to enter next room or return current room.
///</summary>
namespace The_Crib
{
    public partial class CustomDoorMessageBox : Form
    {
        public CustomDoorMessageBox()
        {
            InitializeComponent();
        }
        
        //dictionary for button texts.
        Dictionary<string, string> buttonLibrary = new Dictionary<string, string>()
            {
                {"ReturnBT","return,palaa,повернення,возвращаться" }, // need to verify
                {"ChangeFormBT","open,avaa,ВІДЧИНЕНО,открыть" } // need to verify
            };

        Dictionary<string, string> arrowLibrary = new Dictionary<string, string>()
            {
                {"ReturnBT","return,palaa,повернення,возвращаться" }, // need to verify
                {"ChangeFormBT","go,mene,йти,идти" } // need to verify
            };

        //Method for doors
        public DialogResult ShowDialog(string word, string fiWord, string roomWord, string fiRoom, bool show, int lanId)
        { 
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            OnlyInYardDoorsLB.Text = $"{fiRoom} = {roomWord}";
            OnlyInYardDoorsLB.Visible = show;
            MessageBoxButtonTexts(lanId); // new feature for button translations.
            return this.ShowDialog();
        }

        //Method for arrow to backyaed in front yard view
        public DialogResult ShowDialog1(string word, string fiWord, int lanId)
        {
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            MessageBoxButtonTexts1(lanId);
            return this.ShowDialog();
        }

        //Method for buttons text output
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

        private void MessageBoxButtonTexts1(int lanId)
        {
            string selectedWord = arrowLibrary["ReturnBT"];//Selecting words for ReturnBT from library by key.
            string selectedWord1 = arrowLibrary["ChangeFormBT"];//Selecting words for room ChangeFormBT
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
