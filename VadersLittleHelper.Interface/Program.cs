using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VadersLittleHelper.Backend.dbClasses;

namespace VadersLittleHelper.Interface
{
    static class Program
    {
        public static GameComponentHandler CardHandler;
        public static SquadronHandler SquadHandler;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CardHandler = new GameComponentHandler();
            SquadHandler = new SquadronHandler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
