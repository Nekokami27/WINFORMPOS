using System;
using System.Windows.Forms;
using WINFORM_PRAC.Repository;

namespace WINFORM_PRAC
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth_Page(new ItemRepo("Stock.db")));

        }
    }
}
