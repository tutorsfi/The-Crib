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
/// Version 19.10.2022
/// <summary>
/// Dictionary-class for fridge. Finished
/// </summary>

namespace The_Crib
{
    internal class DictionaryFridge
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all fridge -words
        {
            // order ENG-FI-UA-RUS
            {"CucumberPB","a cucumber,kurkku,огірок,огурец"},
            {"MilkPB","milk,maito,молоко,молоко"},
            {"OrangejuicePB","orange juice,appelsiinimehu,апельсиновий сік,апельсиновый сок"},
            {"MargarinePB","margarine,margariini,маргарин,маргарин"},
            {"TomatoesPB","a tomato,tomaatti,помідор,помидор"},
            {"EggsPB","an egg,kananmuna,яйце,яйцо"},
            {"GroundmeatPB","ground meat,jauheliha,фарш,фарш"},
            {"CheesePB","a cheese,juusto,сир,сыр"},
            {"WaterbottlePB","water,vesi,вода,вода"},
            {"SausagesPB","sausage,makkara,сосиска,сосиска"},
            {"BeerPB","a beer,olut,пиво,пиво"},
            {"BeerTwoPB","a beer,olut,пиво,пиво"},
            {"SaladPB","a salad,salaatti,салат,салат"},
            {"MustardPB","a mustard,sinappi,гірчиця,горчица"},
            {"KetchupPB","a ketchup,ketsuppi,кетчуп,кетчуп"}
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
