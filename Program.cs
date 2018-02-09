using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    static class Program
    {
        public static string dbDir;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dbDir = FindApplicationFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm ());
        }

        public static string FindApplicationFile()
        {
            string startPath = Path.Combine(Application.StartupPath, "Database5.accdb");
            FileInfo file = new FileInfo(startPath);
            while (!file.Exists)
            {
                if (file.Directory.Parent == null)
                {
                    return null;
                }
                DirectoryInfo parentDir = file.Directory.Parent;
                file = new FileInfo(Path.Combine(parentDir.FullName, file.Name));
            }
            return file.FullName;
        }
    }
}
