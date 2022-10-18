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
/// Version 18.10.2022
/// <summary>
/// Dictionary-class for dining room. Unfinished.
/// Dictionary may hold some unused words due to lack of graphics received in time.
/// </summary>

namespace The_Crib
{
    internal class DictionaryDiningRoom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all sauna-words
        {
            // order ENG-FI-UA-RUS
            {"SideTablePB", "a side table,sivupöytä,приставний стіл,приставной столик"},
            {"ChairPB", "a chair, tuoli,стілець,word"},
            {"TablePB", "a table,pöytä,стіл,стол"},
            {"WindowPB", "a window,ikkuna,вікно,окно"},
            {"LampPB", "a ceiling lamp,kattolamppu,люстра,люстра"},
            {"FruitbasketPB","a fruit basket,hedelmäkori"},
            {"CandlelabraPB","a candlelabra,kynttiläjalka"},
            {"CandlesPB","candles,kynttilät"}
        };

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
