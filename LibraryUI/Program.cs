using LibraryEFCore.Context;
using LibraryUI.Forms;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new LibraryContext())
            {
                context.Database.Migrate(); // Migration iþlemini uygular.
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}