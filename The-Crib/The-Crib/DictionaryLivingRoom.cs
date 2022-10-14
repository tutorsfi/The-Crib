using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public class DictionaryLivingRoom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() 
        {
            {"CouchPB","a couch,sohva,диван,диван" },
            {"CoffeeTablePB","a coffee table,sohvapöytä,стіл для кави,кофейный столик" },
            {"TelevisionPB","a television,televisio,телевізор,телевизор" },
            {"TvStandPB","a tv table,tv-taso,тумба під телевізор,тумба под телевизор" },
            {"WindowPB","a window,ikkuna,вікно,окно" },
            {"RemoteControlPB","a remote control,kaukosäädin,пульт,пульт" },
            {"GameConsolPB","a game console,pelikonsoli,ігрова консоль,игровая консоль" },
            {"GameControllerPB","a game controller,ohjain,джойстик,джойстик" },
            {"CurtainsPB","curtains,verhot,штори,шторы" }
        };

        public void Show(string pic, int lanId)
        {
            try
            {
                string selectedWord = wordLibrary[pic];//Selecting words for picture from library by key.
                string[] separators = { "," };//Defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
                string word = wordArr[lanId];//Selecting right word for picture by index.
                string fiWord = wordArr[1];// variable for finnish word
                CustomMessageBoxForm cuMeFo = new CustomMessageBoxForm();// variable for custom message box
                DialogResult result = cuMeFo.ShowDialog(word, fiWord, lanId); // calling "message box"
                if (result == DialogResult.OK)// clicked button in message box
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
