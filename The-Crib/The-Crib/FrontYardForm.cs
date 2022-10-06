using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 5.10.2022
/// <summary>
/// Front yard view. Unfinished. Door doesn't show words yet. It's now serving only button to enter house. MessageBox needs modification to work when player
/// clicks door, idea for that needs testing in demo. Who makes room where door leads should edit correct form name to DoorPB_Click() void and edit this
/// sentance.
///</summary>

namespace The_Crib
{
    public partial class FrontYardForm : Form
    {
        DictionaryFrontYard diFrYa = new DictionaryFrontYard(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public FrontYardForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void FrontYardForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }

        private void HousePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void DoorPB_Click(object sender, EventArgs e)
        {   
            // edit needed comments where line starts
            //PictureBox image = sender as PictureBox;
            //diFrYa.Show(image.Name, lanId); // at this point not in use
            //FrontYardForm frYaFo = new FrontYardForm(); // Next room here 
            //frYaFo.FormClosing += CloseForm; //
            //frYaFo.LanguageId = laId; // passing id to another form
            //frYaFo.Show(); // opening next form
            //this.Hide(); // hiding this one
        }

        private void BushPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void TreePB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void RoofPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowKiPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowMasBedPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowBathroomPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }

        private void WindowWcPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            diFrYa.Show(image.Name, lanId);
        }
    }
}
