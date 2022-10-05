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
/// version 5.10.2022
/// <summary>
/// Kids room view. Unfinished. Currently no other graphics for the room exist than the background.
///</summary>

namespace The_Crib
{
    public partial class KidsRoomForm : Form
    {
        DictionaryKidsRoom diKdRm = new DictionaryKidsRoom(); //variable for dictionary class
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public KidsRoomForm()
        {
            InitializeComponent();
        }
    }
}
