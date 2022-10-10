using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public class DictionaryMasterBedroom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. lang order ENG-FI-UA-RUS
            {"bedMBPB", "a queen size bed,parisänky,двоспальне ліжко,двуспальная кровать" },
            {"bedspreadMBPB", "a bedspread,päiväpeitto,ковдра,покрывало"},
            {"nightstandMBPB", "a nightstand,yöpöytä,столик біля ліжка,прикроватный столик" },
            {"wardrobeMBPB", "a wardrobe,vaatekaappi,шафа для одягу,шкаф для одежды" },
            {"tshirtMBPB", "a t-shirt,t-paita,футболка,футболка" },
            {"socksMBPB", "socks,sukat,шкарпетки,носки" },
            {"underwearMBPB", "underwear,alusvaatteet,нижня білизна,нижнее белье" },
            {"suitMBPB", "a suit,puku,костюм ,костюм" },
            {"ceilingLampMBPB", "a ceiling lamp,kattolamppu,лампалюстра,люстра" },
            {"sweaterMBPB", "a sweater,villapaita,светр,свитер" },
            {"shortsMBPB", "shorts,sortsit,шорти,шорты" },
            {"woollenSocksMBPB", "woollen socks,villasukat,вовняні шкарпетки,шерстяные носки" },
            {"hangerMBPB", "a hanger,henkari,вішалка,вешалка" },
            {"sweatpantsMBPB", "sweatpants,verkkahousut,спортивні штани,спортивные штаны" }
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
                DialogResult result = cuMeFo.ShowDialog(word, fiWord); // calling "message box"
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

