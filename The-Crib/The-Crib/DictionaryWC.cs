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
            {"ToiletPB", "toilet bowl,pönttö,унітаз,унитаз"},
            {"ToiletPaperPB", "toilet paper,vessapaperi,туалетний папір,туалетная бумага"},
            {"MirrorPB", "mirror cabinet,peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"SinkPB", "sink,lavuaari,раковина,раковина"},
            {"TapPB", "tap,Hana,кран,кран"},
            {"SoapPB", "handsoap,käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "toilet brush,vessaharja,йоржик для унітазу,йоржик для унітазу"},
            {"BidetPB", "bidet shower,käsisuihku,біде,гигиенический душ"},
            {"HandTowelPB", "hand towel,käsipyyhe,рушник для рук,полотенце для рук"}
        };

        public void Show(string pic, int lanId)
        {
            try
            {

                string selectedWord = wordLibrary[pic];
                string[] separators = { "," };
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string word = wordArr[lanId];
                string fiWord = wordArr[1];

                CustomMessageBoxForm customMessageBoxForm = new CustomMessageBoxForm();
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord);
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