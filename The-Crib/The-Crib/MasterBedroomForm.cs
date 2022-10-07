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
/// version 7.10.2022
/// <summary>
/// Master bedroom view. Unfinished. There are no graphics for this room´s objects yet.
///</summary>

namespace The_Crib
{
    public partial class MasterBedroomForm : Form
    {
        DictionaryFrontYard dimaBr = new DictionaryFrontYard(); //variable for class where words are 
        
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public MasterBedroomForm()
        {
            InitializeComponent();
        }

        private void ceilingLampMBPB_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            dimaBr.Show(image.Name, lanId);
        }

        private void MasterBedroomForm_Load(object sender, EventArgs e)
        {
            lanId = laId;
        }

    }
}
