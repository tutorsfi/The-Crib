using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 17.10.2022
/// <summary>
/// Backyard Dictionary. Class contains code to show custom MessageBox which shows pictures name in FI - selected language.
///</summary>
namespace The_Crib
{
    public class DictionaryBackyard
    {
        Dictionary<string, string> backyardLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. value order ENG-FI-UA-RUS
            {"HousePB", "a house,talo,дім,дом" },// Words for house
            {"RoofPB","a roof,katto,дах,крыша" },// Words for roof
            {"WindowDRPB","a window,ikkuna,вікно,окно" },// Words for Window
            {"WindowSRPB","a window,ikkuna,вікно,окно" },// Words for Window
            {"WindowKRPB","a window,ikkuna,вікно,окно" },// Words for Window
            {"SwingPB","a swing,keinu,гойдалки,качели" },// Words for Swing
            {"OutdoorTablePB","an outdoor table,puutarhapöytä,садовий стіл,садовый стол" },// Words for outdoor table
            {"OutdoorChairPB","an outdoor chair,puutarhatuoli,садовий стілець,садовый стул" },// Words for outdoor chair
            {"ToyShovelPB","a toy shovel,lelulapio,іграшкова лопатка,игрушечная лопатка" },// Words for toy shovel
            {"ToyBucketPB","a bucket,ämpäri,відро,ведро" },// Words for bucket
            {"TerracePB","terrace,terassi,тераса,терраса" },//Words for terrace
            {"RakePB","a rake,harava,граблі,грабли" },// Words for rake
            {"BroomPB","a broom,harja,мітла,метла" }// Words for broom
            /*{"","a sandbox,hiekkalaatikko,пісочниця,песочница" },// Words for sandbox           
            //{"","a sunshade,auringonvarjo,парасолька для сонця,зонт от солнца" },// Words for sunshade
            //{"","a grill,grilli,гриль,гриль" },// Words for grill
            //{"","a playhouse,leikkimökki,ігровий дім,игровой домик" },// Words for playhouse
            //{"","a ball,pallo,м'яч,мяч" },// Words for ball*/
        };


        public void Show(string pic, int lanId)
        {
            try
            {
                string selectedWord = backyardLibrary[pic];//Selecting words for picture from library by key.
                string[] separators = { "," };//Defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);//Words to array
                string word = wordArr[lanId];//Selecting right word for picture by index.
                string fiWord = wordArr[1];// variable for finnish word
                CustomMessageBoxForm cuMeFo = new CustomMessageBoxForm();// variable for custom message box
                DialogResult result = cuMeFo.ShowDialog(word, fiWord,lanId); // calling "message box"
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
