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
            {"PicName", "Word,Sana,Word,Word"},
            {"PicName", "Word,Sana,Word,Word"}
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
                string enWord = wordArr[1];
                string uaWord = wordArr[2];
                string ruWord = wordArr[3];

                // MyNewMessageBox myNewMessageBoxInstance = new MyNewMessageBox();
                // DialogResult result = myNewMessageBoxInstance.ShowDialog(word,fiWord,uaWord,ruWord);
                // if (result == DialogResult.OK)
                // {
                //      myNewMessageBoxInstance.Close();
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
