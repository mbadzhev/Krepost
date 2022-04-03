using KrepostLib.Security;
using KrepostLib.Storage;

namespace KrepostWinForms
{
    internal static class Program
    {
        public static DatabaseFile CurrentDbFile { get; set; }
        public static string DbFilePath { get; set; }
        public static Database? CurrentDb { get; set; }
        public static DatabaseHead CurrentDbHead { get; set; }
        public static bool OpenDatabase { get; set; }
        /// <summary>
        /// Gets or sets the value indicating whether all database changes are saved.
        /// </summary>
        public static bool SavedDatabase { get; set; }
        public static SecureByteArray? CurrentKey { get; set; }
        public static DatabaseEntry SelectedEntry { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set initial values for fields.
            OpenDatabase = false;
            SavedDatabase = true;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.MainForm());

        }
    }
}