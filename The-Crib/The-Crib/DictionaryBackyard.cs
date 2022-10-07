using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 6.10.2022
/// <summary>
/// Backyard Dictionary. Not working yet .Class contains code to show custom MessageBox which shows pictures name in FI - selected language.
///</summary>
namespace The_Crib
{
    public class DictionaryBackyard
    {
        Dictionary<string, string> backyardLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. value order ENG-FI-UA-RUS
            {"HousePB", "a house,talo,дім,дом" },// Words for house
            {"RoofPB","a roof,katto,дах,крыша" }// Words for roof
           /* {"","" },// Words for bush
            {"","" }// Words for Tree*/
        };


        public void Show(string pic, int lanId)
        {
            try
            {
                string selectedWord = backyardLibrary[pic];//Selecting words for picture from library by key.
                string[] separators = { "," };//Defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
                string word = wordArr[lanId];//Selecting right word for picture by index.
                string fiWord = wordArr[1];// variable for finnish word
                CustomMessageBoxForm cuMeFo = new CustomMessageBoxForm();// variable for custom message box
                DialogResult result = cuMeFo.ShowDialog(word, fiWord); // calling "message box"
                if (result == DialogResult.OK)// clicked button in message box
                {
                    cuMeFo.Close(); // closing form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
