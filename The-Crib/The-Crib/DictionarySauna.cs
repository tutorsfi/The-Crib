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
    public class DictionarySauna
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all sauna-words
        {
            // order ENG-FI-UA-RUS
            {"SaunaStovePB", "a sauna stove,kiuas,банна піч,банная печь"},
            {"SaunaBenchOnePB", "sauna benches,lauteet,лавка у сауні,лавки для сауны"},
            {"SaunaBenchTwoPB", "sauna benches,lauteet,лавка у сауні,лавки для сауны"},
            {"StonesPB", "stove stones,kiuaskivet,камні для печі,камни для печи"},
            {"PailPB", "a pail,kiulu,відро для сауни,ведро для сауны"},
            {"LadlePB", "a sauna ladle,saunakauha,ківш для сауни,ковш для сауны"},
            {"GnomePB", "a sauna gnome,saunatonttu,гном для сауни,гном для сауны"},
            {"ThermometerPB", "a thermometer,lämpömittari,термометр,термометр"}
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
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord); // selecting the words for the custom messagebox
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
