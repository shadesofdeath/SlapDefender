using SlapDefender;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace SlapDefender
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("The program must be run with Administrator privileges! Please, try again to run the program with that privileges or it will not work.", "SlapDefender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
