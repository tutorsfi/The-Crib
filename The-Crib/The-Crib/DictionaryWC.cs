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
    public class DictionaryWC
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {
            // order ENG-FI-UA-RUS
            {"ToiletPB", "Toilet bowl,Pönttö,унітаз,унитаз"},
            {"ToiletPaperPB", "Toilet paper,Vessapaperi,туалетний папір,туалетная бумага"},
            {"MirrorPB", "Mirror cabinet,Peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"SinkPB", "Sink,Lavuaari,раковина,раковина"},
            {"TapPB", "Tap,Hana,кран,кран"},
            {"SoapPB", "Handsoap,Käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "Toilet brush,Vessaharja,йоржик для унітазу,йоржик для унітазу"},
            {"BidetPB", "Bidet shower,Käsisuihku,біде,гигиенический душ"},
            {"HandTowelPB", "Hand towel,Käsipyyhe,рушник для рук,полотенце для рук"}
        };

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
                DialogResult result = customMessageBoxForm.ShowDialog(uaWord, fiWord);
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