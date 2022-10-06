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
    public class DictionaryBathroom
    {
        // Dictionary to store all the words
        // first is the name of the picturebox, second comes the words in different languages
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {
            // order ENG-FI-UA-RUS
            {"ToiletPB", "Toilet bowl,Pönttö,унітаз,унитаз"},
            {"MirrorPB", "Mirror cabinet,Peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"HandsoapPB", "Handsoap,Käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "Toilet brush,Vessaharja,йоржик для унітазу,ёршик для унитаза"},
            {"SinkPB", "Sink,Lavuaari,раковина,раковина"},
            {"TapPB", "Tap,Hana,кран,кран"},
            {"TowelPB","Towel,Pyyhe,рушник,полотенце"},
            {"ToothBrushPB","Tooth brush,Hammasharja,зубна щітка,зубная щетка"},
            {"ShowerPB","Shower,Suihku,душ,душ"},
            {"WashingMachinePB","Washing machine,Pyykinpesukone,пральна машина,стиральная машина"},
            {"ToothPastePB","Toothpaste,Hammastahna,зубна паста,зубная паста"},
            {"ShampooPB","Shampoo,Shampoo,шампунь,шампунь"},
            {"DetergentPB","Laundry detergent,Pyykinpesuaine,пральний порошок,стиральный порошок"}
        };

        // Method to show the custom messagebox with the original and translated word
        public void Show(string pic, int lanId)
        {
            try
            {

                string selectedWord = wordLibrary[pic];
                string[] separators = { "," };
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string word = wordArr[lanId];
                string enWord = wordArr[0];
                string fiWord = wordArr[1];
                string uaWord = wordArr[2];
                string ruWord = wordArr[3];

                CustomMessageBoxForm customMessageBoxForm = new CustomMessageBoxForm();
                DialogResult result = customMessageBoxForm.ShowDialog(word,fiWord);
                if (result == DialogResult.OK)
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
