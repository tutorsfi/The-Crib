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
/// Form where player can view credits and start game. Maybe should add instructions button here to show how the game is played?
///</summary>

namespace The_Crib
{
    public partial class MainMenuForm : Form
    {
        int lanId; // variable for language id
        private int laId; // private declariation for get/set
        public int LanguageId // get/set defenition
        {
            get { return laId; }
            set { laId = value; }
        }
        public MainMenuForm()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void StartGameForm_Load(object sender, EventArgs e)
        {
            lanId = laId;// not necessarily needed
        }

        private void StartGameBT_Click(object sender, EventArgs e)
        {
            FrontYardForm frYaFo = new FrontYardForm(); // FrontYardForm 
            frYaFo.FormClosing += CloseForm; //
            frYaFo.LanguageId = laId; // passing id to another form
            frYaFo.Show(); // opening next form
            this.Hide(); // hiding this one
        }

        private void CreditsBT_Click(object sender, EventArgs e)
        {

        }
    }
}
