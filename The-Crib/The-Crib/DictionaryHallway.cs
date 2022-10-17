using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// author@ Jenna Koskelo
/// version 17.10.2022
/// <summary>
/// Dictionary for downstairs hallway, includes all words for the room´s objects.
///</summary>

namespace The_Crib
{
    public class DictionaryHallway
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. lang order ENG-FI-UA-RUS
            {"stairsHWPB", "stairs,portaat,сходи,лестница" },
            {"closetHWPB", "a closet,kaappi,шафа,шкаф"},
            {"jacketHWPB", "a jacket,takki,куртка,куртка" },
            {"shoesHWPB", "shoes,kengät,взуття,обувь" },
            {"rugHWPB", "a rug,matto,килим,ковер" },
            {"mirrorHWPB", "a mirror,peili,дзеркало,зеркало" },
            {"capHWPB", "a cap,lippis,кепка,кепка" },
            {"beanieHWPB", "a beanie,pipo,шапка ,шапка" },
            {"mittensHWPB", "mittens,lapaset,рукавиці,рукавицы" },
            {"scarfHWPB", "a scarf,kaulahuivi,шарф,шарф" }
        };

        public void Show(string pic, int lanId)
        {
            try
            {
                string selectedWord = wordLibrary[pic]; //Select dictionary key as value
                string[] separators = { "," };  //select commas as array separators
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);   //Words to array
                string word = wordArr[lanId];   //Selecting right language word for picture by index.
                string fiWord = wordArr[1]; //finnish word is always index value 1
                CustomMessageBoxForm cuMeFo = new CustomMessageBoxForm();   // variable for custom message box
                DialogResult result = cuMeFo.ShowDialog(word, fiWord, lanId); // calling "message box"
                if (result == DialogResult.OK)  // clicked OK in message box
                {
                    cuMeFo.Close(); // closing form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
