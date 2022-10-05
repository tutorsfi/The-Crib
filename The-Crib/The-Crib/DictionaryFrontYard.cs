using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public class DictionaryFrontYard
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. value order ENG-FI-UA-RUS
            {"HousePB", "a house,talo,дім,дом" },// Words for house
            {"DoorPB", "a door,ovi,двері,дверь"}// Words for door
        };


        public void Show(string pic, int lanId)
        {
            try
            {
                string selectedWord = wordLibrary[pic];//Selecting words for picture from library by key.
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
