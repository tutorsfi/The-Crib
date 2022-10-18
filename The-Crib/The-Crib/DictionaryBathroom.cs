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
/// Dictionary-class for bathroom. Finished.
/// Dictionary may hold some unused words due to lack of graphics received in time.
/// </summary>

namespace The_Crib
{
    public class DictionaryBathroom
    {
        
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all bathroom-words
        {
            // order ENG-FI-UA-RUS
            {"ToiletPB", "a toilet bowl,pönttö,унітаз,унитаз"},
            {"MirrorCabinetPB", "a mirror cabinet,peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"HandsoapPB", "a handsoap,käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "a toilet brush,vessaharja,йоржик для унітазу,ёршик для унитаза"},
            {"SinkPB", "a sink,lavuaari,раковина,раковина"},
            {"TowelPB","a towel,pyyhe,рушник,полотенце"},
            {"ToothBrushPB","a tooth brush,jammasharja,зубна щітка,зубная щетка"},
            {"ShowerPB","a shower,suihku,душ,душ"},
            {"WashingMachinePB","a washing machine,pyykinpesukone,пральна машина,стиральная машина"},
            {"ToothPastePB","a toothpaste,hammastahna,зубна паста,зубная паста"},
            {"ShampooPB","a shampoo,shampoo,шампунь,шампунь"},
            {"DetergentPB","a laundry detergent,pyykinpesuaine,пральний порошок,стиральный порошок"},
            {"ToiletpaperPB","a toilet paper,vessapaperi,word,word"}
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
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord,lanId); // selecting the words for the custom messagebox
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
