using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// author@ Jenna Koskelo
/// version 18.10.2022
/// <summary>
/// Kids room wardrobe view. Some graphics missing.
///</summary>

namespace The_Crib
{
    public partial class KidsWardrobeForm : Form
    {
        DictionaryKidsRoom kids = new DictionaryKidsRoom(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public KidsWardrobeForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void pantsKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void shirtKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void dressKRPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            kids.Show(image.Name, lanId);
        }

        private void KidsWardrobeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void KidsWardrobeForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }
    }
}
