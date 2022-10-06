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
    public partial class CustomDoorMessageBox : Form
    {
        public CustomDoorMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string word, string fiWord)
        {
            WordLB.Text = $"{fiWord} = {word}"; // label in "message box"
            return this.ShowDialog();
        }
    }
}
