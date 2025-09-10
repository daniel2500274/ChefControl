using ChefControl.Data;
using ChefControl.Models;

namespace ChefControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Initialize Basic Categories of food:
            InMemoryDB.Categories.AddRange(new[]
            {
                new Category{Id=1, Nombre = "Entradas"},
                new Category{Id=2, Nombre = "Principales" },
                new Category{Id=3, Nombre = "Postres" },
                new Category{Id=4,Nombre = "Bebidas" },
            });


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}