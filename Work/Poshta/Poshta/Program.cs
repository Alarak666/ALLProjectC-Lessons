using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poshta
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            String dbPathMyDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String dbPath = Path.Combine(dbPathMyDoc, "DataBase");
            AppDomain.CurrentDomain.SetData("DataDirectory",dbPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
