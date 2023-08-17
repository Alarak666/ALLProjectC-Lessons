using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poshta2._0
{
    public static class Connection
    {
        //public static SQLiteConnection  connection = new SQLiteConnection(@"Data Source = UkrPoshta.db;Version=3");
        private static string database =
               // AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Database\\ImageLib.s3db";
                "UkrPoshta.db";
        private static string connectionString = @"Data Source=" + Path.GetFullPath(database) + ";Version=3;";
        public static SQLiteConnection connection = new SQLiteConnection(connectionString);
    }
}
