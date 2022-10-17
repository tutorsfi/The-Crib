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
/// version 17.10.2022
/// <summary>
/// UA-FI home game startpage where player selects language used while palying game. Id numbers are decided by order of languages in game document
/// Excel file ENG-FI-UA-RUS and numbered according C# index policy.
/// </summary>

namespace The_Crib
{
    public partial class Form1 : Form
    {
        public static int laId; // variable for languange id
        bool laSe = false; // variable to check there is selected language
        public Form1()
        {
            InitializeComponent();
        }

        void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void UkrainianLaBT_Click(object sender, EventArgs e)
        {
            try 
            {
                laId = 2; // language id number for ukrainian language
                MainMenuForm MaMeFo = new MainMenuForm(); // MainMenuForm 
                MaMeFo.FormClosing += CloseForm; //
                MaMeFo.LanguageId = laId; // passing id to another form
                MaMeFo.Show(); // opening next form
                this.Hide(); // hiding this one
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RussianLaBT_Click(object sender, EventArgs e)
        {
            try
            {
                laId = 3; // language id number for russian language
                MainMenuForm MaMeFo = new MainMenuForm(); // MainMenuForm 
                MaMeFo.FormClosing += CloseForm; //
                MaMeFo.LanguageId = laId; // passing id to another form
                MaMeFo.Show(); // opening next form
                this.Hide(); // hiding this one
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NextFormBT_Click(object sender, EventArgs e)
        {

        }

        private void EnglishLaBT_Click(object sender, EventArgs e)
        {
            try
            {
                laId = 0; // language id number for english language
                MainMenuForm MaMeFo = new MainMenuForm(); // MainMenuForm 
                MaMeFo.FormClosing += CloseForm; //
                MaMeFo.LanguageId = laId; // passing id to another form
                MaMeFo.Show(); // opening next form
                this.Hide(); // hiding this one
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
