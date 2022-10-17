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
    class DictionaryKitchen
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {
            // order ENG-FI-UA-RUS
            {"OvenKPB", "an oven,uuni,піч,духовка"},
            {"StoveKPB", "a stove,hella,плита,плита"},
            {"CoffeeMakerKPB", "a coffee maker,kahvinkeitin,кавоварка,кофеварка"},
            {"MicrowaveOvenKPB", "a microwave,mikro,мікрохвильова піч,микроволновая печь"},
            {"DryingCabinetKPB", "a drying cabinet,kuivauskaappi,сушильна шафа,шкаф для сушки"},
            {"SinkKPB", "a sink,lavuaari,раковина,раковина"},
            {"TapKPB", "a tap,hana,кран,кран"},
            {"WindowPB", "a window,ikkuna,вікно,окно"},
            {"TrashPB","a trash bin,roskakori,word,word"}
        };

        public void Show(string pic, int lanId)
        {
            try
            {

                string selectedWord = wordLibrary[pic];
                string[] separators = { "," };
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string word = wordArr[lanId];
                string fiWord = wordArr[0];

                CustomMessageBoxForm customMessageBoxForm = new CustomMessageBoxForm();
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord,lanId);
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
