using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                try
                {
                    MainCoordinator.Instance.OpenLoginForm();
                    Application.Run();
                }
                catch (ServerException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
        }
    }
}
