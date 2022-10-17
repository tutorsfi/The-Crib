using System;
using System.Collections.Generic;
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
            {"FridgeKPB", "a fridge,jääkaappi,холодильник,холодильник"},
            {"FreezerKPB", "a freezer,pakastin,морозильна камера,морозильна камера"},
            {"OvenKPB", "an oven,uuni,піч,духовка"},
            {"StoveKPB", "a stove,hella,плита,плита"},
            {"CoffeeMakerKPB", "a coffee maker,kahvinkeitin,кавоварка,кофеварка"},
            {"MicrowaveOvenKPB", "a microwave,mikro,мікрохвильова піч,микроволновая печь"},
            {"DryingCabinetKPB", "a drying cabinet,kuivauskaappi,сушильна шафа,шкаф для сушки"},
            {"SinkKPB", "a sink,lavuaari,раковина,раковина"},
            {"TapKPB", "a tap,hana,кран,кран"},
            {"DrawerKPB", "a drawer,vetolaatikko,шухляда,выдвижной ящик"}
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
