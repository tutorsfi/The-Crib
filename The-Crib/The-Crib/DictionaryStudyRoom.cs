using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public class DictionaryStudyRoom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. lang order ENG-FI-UA-RUS
            {"deskSTPB", "a desk,työpöytä,робочий стіл,рабочий стол" },
            {"chairSTPB", "an office chair,työtuoli,офісний стілець,офисный стул"},
            {"laptopSTPB", "a laptop,läppäri,ноутбук,ноутбук" },
            {"bookshelfSTPB", "a bookshelf,kirjahylly,книжкова шафа,книжный шкаф" },
            {"phoneSTPB", "a phone,puhelin,телефон,телефон" },
            {"penSTPB", "a pen,kynä,ручка,ручка" },
            {"notebookSTPB", "a notebook,muistivihko,блокнот,блокнот" },
            {"desklampSTRPB", "a desk lamp,pöytälamppu,настільна лампа,настольная лампа" },
            {"pcMouseSTPB", "a pc mouse,hiiri,миш,мышь" },
            {"calendarSTPB", "a calendar,kalenteri,календар,календарь" },
            {"extensionCordSTPB", "an extension cord,jatkojohto,подовжувач,удлинитель" }
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

