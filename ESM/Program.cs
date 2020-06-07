using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string EMS_Ver;

        [STAThread]
      
        static void Main()
        {
            //  --  Select Lagnuage  --

            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(language);
            //  --  Read Assembly version --
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            EMS_Ver = fvi.FileVersion;
            //  -----------------------------


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeSysMainForm());
        }
    }
}
