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
    public partial class MasterBedroomWardrobeForm : Form
    {

        DictionaryMasterBedroom bedroom = new DictionaryMasterBedroom(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public MasterBedroomWardrobeForm()
        {
            InitializeComponent();
        }
    }
}
