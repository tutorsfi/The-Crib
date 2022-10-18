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
/// Dictionary-class for wc. Finished.
/// Dictionary may hold some unused words due to lack of graphics received in time.
/// </summary>

namespace The_Crib
{
    public class DictionaryWC
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all wc-words
        {
            // order ENG-FI-UA-RUS
            {"ToiletPB", "a toilet bowl,pönttö,унітаз,унитаз"},
            {"ToiletpaperPB", "a toilet paper,vessapaperi,туалетний папір,туалетная бумага"},
            {"SinkPB", "a sink,lavuaari,раковина,раковина"},
            {"LampPB","a ceiling lamp,kattolamppu,люстра,люстра"},
            {"SoapPB", "a handsoap,käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "a toilet brush,vessaharja,йоржик для унітазу,йоржик для унітазу"},
            {"BidetPB", "a bidet shower,käsisuihku,біде,гигиенический душ"},
            {"HandtowelPB", "a hand towel,käsipyyhe,рушник для рук,полотенце для рук"},
            {"PlantPB","a plant,kasvi,word,word"}
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