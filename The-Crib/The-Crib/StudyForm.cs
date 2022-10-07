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
/// Study room view. Unfinished. There are no graphics for this room´s objects yet.
///</summary>

namespace The_Crib
{
    public partial class StudyForm : Form
    {

        DictionaryFrontYard diFrYa = new DictionaryFrontYard(); //variable for class where words are 
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }

        public StudyForm()
        {
            InitializeComponent();
        }
    }
}
