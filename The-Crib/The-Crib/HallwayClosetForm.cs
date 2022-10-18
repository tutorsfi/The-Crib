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
/// Downstairs hallway closet view. Finished.
///</summary>

namespace The_Crib
{
    public partial class HallwayClosetForm : Form
    {
        DictionaryHallway hallway = new DictionaryHallway(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public HallwayClosetForm()
        {
            InitializeComponent();
        }

        private void jacketHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void shoesHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void capHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void beanieHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void mittensHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }

        private void scarfHWPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            hallway.Show(image.Name, lanId);
        }
    }
}
