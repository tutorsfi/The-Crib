using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Crib
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new BathroomForm());
            //Application.Run(new BackYardForm());
            //Application.Run(new MasterBedroomForm());
            //Application.Run(new MainMenuForm());
            //Application.Run(new StudyForm());
            //Application.Run(new KidsRoomForm());
            //Application.Run(new SaunaForm());
            Application.Run(new WcForm());
        }
    }
    
}
