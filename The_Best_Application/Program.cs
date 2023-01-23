using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace The_Best_Application
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);

            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
                new Database("Data Source=dataBase.db;Version=3;").InitializeDatabase();

            Application.Run(new FormMain());
        }
    }
}
