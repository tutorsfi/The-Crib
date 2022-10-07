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
            {"ToiletPB", "toilet bowl,pönttö,унітаз,унитаз"},
            {"MirrorPB", "mirror cabinet,peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"HandsoapPB", "handsoap,käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "toilet brush,vessaharja,йоржик для унітазу,ёршик для унитаза"},
            {"SinkPB", "sink,lavuaari,раковина,раковина"},
            {"TowelPB","towel,pyyhe,рушник,полотенце"},
            {"ToothBrushPB","tooth brush,jammasharja,зубна щітка,зубная щетка"},
            {"ShowerPB","shower,suihku,душ,душ"},
            {"WashingMachinePB","washing machine,pyykinpesukone,пральна машина,стиральная машина"},
            {"ToothPastePB","toothpaste,hammastahna,зубна паста,зубная паста"},
            {"ShampooPB","shampoo,shampoo,шампунь,шампунь"},
            {"DetergentPB","laundry detergent,pyykinpesuaine,пральний порошок,стиральный порошок"}
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
