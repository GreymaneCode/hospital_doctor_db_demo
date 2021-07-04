using System;
using System.Windows.Forms;

namespace DataBase_Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new doctor_menu("100001"));         
            System.Environment.Exit(0);
        }
    }
}
