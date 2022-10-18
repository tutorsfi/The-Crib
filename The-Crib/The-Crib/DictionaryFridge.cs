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
/// Dictionary-class for fridge. Unfinished.
/// Dictionary may hold some unused words due to lack of graphics received in time.
/// </summary>

namespace The_Crib
{
    internal class DictionaryFridge
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all fridge -words
        {
            // order ENG-FI-UA-RUS
            {"CucumberPB","a cucumber,kurkku"},
            {"MilkPB","a milk,maito,word,word"},
            {"OrangejuicePB","an orange juice,appelsiinimehu,word,word"},
            {"MargarinePB","a margarine,margariini,word,word"},
            {"TomatoesPB","a tomato,tomaatti,word,word"},
            {"EggsPB","eggs,munia,word,word"},
            {"GroundmeatPB","ground meat,jauheliha"},
            {"CheesePB","a cheese,juusto"},
            {"WaterbottlePB","a water bottle,vesipullo"},
            {"SausagesPB","sausages,makkaroita"},
            {"BeerPB","a beer,olut"},
            {"BeerTwoPB","a beer,olut"},
            {"SaladPB","a salad,salaatti"},
            {"MustardPB","a mustard,sinappi"},
            {"KetchupPB","a ketchup,ketsuppi"}
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
