using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 17.10.2022
/// <summary>
/// Living room Dictionary. Class contains code to show custom MessageBox which shows pictures name in FI - selected language.
///</summary>
namespace The_Crib
{
    public class DictionaryLivingRoom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. value order ENG-FI-UA-RUS
            {"CouchPB","a couch,sohva,диван,диван" }, // Words for couch
            {"CoffeeTablePB","a coffee table,sohvapöytä,стіл для кави,кофейный столик" }, // Words for coffee table
            {"TelevisionPB","a television,televisio,телевізор,телевизор" }, // Words for television
            {"TvStandPB","a tv table,tv-taso,тумба під телевізор,тумба под телевизор" }, // Words for tv table
            {"WindowPB","a window,ikkuna,вікно,окно" }, // Words for Window
            {"RemoteControlPB","a remote control,kaukosäädin,пульт,пульт" }, // Words for remote control
            {"GameConsolPB","a game console,pelikonsoli,ігрова консоль,игровая консоль" }, // Words for game console
            {"GameControllerPB","a game controller,ohjain,джойстик,джойстик" }, // Words for game controller
            {"CurtainsPB","curtains,verhot,штори,шторы" }, // Words for curtains
            {"FlowersPB","flowers,kukkia,квіти,цветы" }, // Words for flowers
            {"MagazinePB","a magazine,aikakausilehti,журнал,журнал" }, // Words for magazine
            {"NewspaperPB","a newspaper,sanomalehti,газета,газета" }, // Words for newspaper
            {"DecorativePillowPB","decorative pillow,koristetyyny,декоративна подушка,декоративная подушка" }, // Words for pillow
            {"FlowerTablePB","a flower table,kukkapöytä,квітковий стіл,цветочный стол" }, // need to verify
            {"BlanketPB","a blanket,viltti,ковдра,плед одеяло" } // Words for blanket
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
