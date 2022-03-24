using KrepostLib.Security;
using KrepostLib.Storage;

namespace KrepostWinForms
{
    internal static class Program
    {
        public static DatabaseFile CurrentDbFile { get; set; }
        public static Database? CurrentDb { get; set; }
        public static DatabaseHead CurrentDbHead { get; set; }
        public static bool OpenDatabase { get; set; }
        public static SecureByteArray? CurrentKey { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.MainForm());

            // No database is opened at the start of the application
            OpenDatabase = false;
        }
    }
}