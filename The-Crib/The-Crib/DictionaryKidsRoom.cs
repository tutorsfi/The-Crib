using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    public class DictionaryKidsRoom
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>()
        {   // PictureBox name is key. lang order ENG-FI-UA-RUS
            {"kidsBedKRPB", "a kid's bed,lasten sänky,дитяче ліжко,детская кровать" },
            {"pillowKRPB", "a pillow,tyyny,подушка,подушка"},
            {"duvetKRPB", "a duvet,peitto,ковдра,одеяло" },
            {"wardrobeKRPB", "a wardrobe,vaatekaappi,шафа для одягу,шкаф для одежды" },
            {"teddyKRPB", "a teddy bear,nalle,мішка Тедді,мишка Тедди" },
            {"toyCubesKRPB", "toy cubes,palikat,іграшкові кубики,игрушечные кубики" },
            {"dollKRPB", "a doll,nukke,лялька,кукла" },
            {"toyCarKRPB", "a toy car,leluauto,іграшкова машинка,игрушечная машина" },
            {"shirtKRPB", "a shirt,paita,сорочка,рубашка" },
            {"pantsKRPB", "pants,housut,штани,штаны" },
            {"dressKRPB", "a dress,mekko,плаття,платье" },
            {"dogKRPB", "a dog,koira,собака,собака" },
            {"catKRPB", "a cat,kissa,кішка,кошка" },
            {"bunnyKRPB", "a bunny,pupu,кролик,кролик" },
            {"dollHouseKRPB", "a doll house,nukkekoti,дім для кукол,дом для кукол" },
            {"posterKRPB", "a poster,juliste,постер,постер" },
            {"princessKRPB", "a princess costume,prinsessa-asu,костюм принцеси,костюм принцессы" },
            {"superheroKRPB", "a superhero costume, supersankariasu,костюм супергероя,костюм супергероя" }
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
