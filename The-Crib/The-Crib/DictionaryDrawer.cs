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
/// Version 19.10.2022
/// <summary>
/// Dictionary-class for a drawer in the kitchen. Finished.
/// </summary>

namespace The_Crib
{
    internal class DictionaryDrawer
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {
            // order ENG-FI-UA-RUS
            {"ScissorsPB","scissors,sakset,ножиці,ножницы"},
            {"SpoonPB","a spoon,lusikka,ложка,ложка"},
            {"ForkPB","a fork,haarukka,виделка,вилка"},
            {"KnifePB","a knife,veitsi,ніж,нож"}
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
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord, lanId);
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
