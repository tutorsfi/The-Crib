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
/// Backyard view. Unfinished. Door doesn't show words yet. It's now serving only button to enter house. MessageBox needs modification to work when player
/// clicks door, idea for that needs testing in demo.
///</summary>
namespace The_Crib
{
    public partial class BackYardForm : Form
    {
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public BackYardForm()
        {
            InitializeComponent();
        }

        private void BackYardForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }


    }
}
