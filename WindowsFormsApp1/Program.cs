using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());

            Login_form login_Form = new Login_form();
            if (login_Form.ShowDialog() == DialogResult.OK) ;
            {
                Application.Run(new FormMenuPrincipal());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}

