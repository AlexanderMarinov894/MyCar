using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCar.Forms;
using MyCar.Data;
using MyCar.Forms.Prompts;

namespace MyCar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var database = new DataProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (database.IsEmptyTable("Vehichles"))
            {
                Application.Run(new NewVehichleConfirm());
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}
