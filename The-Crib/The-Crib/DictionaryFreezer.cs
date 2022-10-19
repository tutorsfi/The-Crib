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

/// Author@ Karoliina Salo
/// Version 19.10.2022
/// <summary>
/// Dictionary-class for freezer. Finished.
/// </summary>
{
    internal class DictionaryFreezer
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all freezer -words
        {
            // order ENG-FI-UA-RUS
            {"PizzaPB","a pizza,pitsa,піцца,пицца"},
            {"BerriesPB","frozen berries,pakastemarjat,заморожені ягоди,замороженные ягоды"},
            {"VeggiesPB","frozen vegetables,pakastevihannekset,заморожені овочі,замороженные овощи"},
            {"IcecreamPB","an ice cream,jäätelö,морозиво,мороженое"}
        };

        // Method to show the custom messagebox with the original and translated word
        public void Show(string pic, int lanId)
        {
            try
            {

                string selectedWord = wordLibrary[pic]; // selecting the words from the library
                string[] separators = { "," }; // defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
                string word = wordArr[lanId]; // selecting the right word for the label
                string fiWord = wordArr[1];

                CustomMessageBoxForm customMessageBoxForm = new CustomMessageBoxForm(); // custom messagebox
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord, lanId); // selecting the words for the custom messagebox
                if (result == DialogResult.OK) // when OK is clicked, the messagebox closes
                {
                    customMessageBoxForm.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
