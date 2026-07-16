using System;
using System.Windows.Forms;

namespace SERVICESNOW
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_inicio());
        }
    }
}