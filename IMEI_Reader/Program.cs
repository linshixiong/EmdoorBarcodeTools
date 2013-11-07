using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMEI_Reader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args != null && args.Length > 0)
            {
                if ("write".Equals(args[0]))
                {
                    Application.Run(new Writer());
                    return;
                }
            }

            Application.Run(new Printer());
        }
    }
}
