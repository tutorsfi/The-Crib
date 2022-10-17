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
    public partial class FreezerForm : Form
    {
        readonly DictionaryFreezer look = new DictionaryFreezer();

        public FreezerForm()
        {
            InitializeComponent();
        }

        int lanId; // variable for language-id
        private int laId; // private declaration for get/set

        public int LanguageId // get/set -definition
        {
            get { return laId; }
            set { laId = value; }
        }

        private void FreezerForm_Load(object sender, EventArgs e)
        {
            lanId = laId; // passing the language id to this form
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void FreezerImgPB(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox; // when any image is clicked, it will call the class 
            look.Show(image.Name, lanId);
        }
    }
}
