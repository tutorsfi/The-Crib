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
            {"StovePB", "Sauna stove,Kiuas,банна піч,банная печь"},
            {"BenchesPB", "Sauna benches,Lauteet,лавка у сауні,лавки для сауны"},
            {"StonesPB", "Stove stones,Kiuaskivet,камні для печі,камни для печи"},
            {"PailPB", "Pail,Kiulu,відро для сауни,ведро для сауны"},
            {"LadlePB", "Sauna ladle,Saunakauha,ківш для сауни,ковш для сауны"},
            {"GnomePB", "Sauna gnome,Saunatonttu,гном для сауни,гном для сауны"},
            {"ThermometerPB", "Thermometer,Lämpömittari,термометр,термометр"}
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
