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
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {
            // order ENG-FI-UA-RUS
            {"StovePB", "sauna stove,kiuas,банна піч,банная печь"},
            {"BenchesPB", "sauna benches,lauteet,лавка у сауні,лавки для сауны"},
            {"StonesPB", "stove stones,kiuaskivet,камні для печі,камни для печи"},
            {"PailPB", "pail,kiulu,відро для сауни,ведро для сауны"},
            {"LadlePB", "sauna ladle,saunakauha,ківш для сауни,ковш для сауны"},
            {"GnomePB", "sauna gnome,saunatonttu,гном для сауни,гном для сауны"},
            {"ThermometerPB", "thermometer,lämpömittari,термометр,термометр"}
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
