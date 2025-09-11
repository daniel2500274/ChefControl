using ChefControl.Data;
using ChefControl.Models;
using System;
using System.Windows.Forms;

namespace ChefControl
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Data default
            InMemoryDB.Categories.AddRange(new[]
            {
                new Category { Id = 1, Name = "Entradas" },
                new Category { Id = 2, Name = "Principales" },
                new Category { Id = 3, Name = "Postres" },
                new Category { Id = 4, Name = "Bebidas" },
            }); 
            InMemoryDB.Dishes.AddRange(new[]
            {
                // Entradas
                new Dish { Id = 1, Name = "Bruschettas", Category = InMemoryDB.Categories[0], Price = 8.50m },
                new Dish { Id = 2, Name = "Ensalada César", Category = InMemoryDB.Categories[0], Price = 10.00m },
                // Principales
                new Dish { Id = 3, Name = "Lomo Saltado", Category = InMemoryDB.Categories[1], Price = 25.00m },
                new Dish { Id = 4, Name = "Pasta Alfredo", Category = InMemoryDB.Categories[1], Price = 18.75m },
                // Postres
                new Dish { Id = 5, Name = "Tiramisú", Category = InMemoryDB.Categories[2], Price = 12.50m },
                new Dish { Id = 6, Name = "Flan", Category = InMemoryDB.Categories[2], Price = 7.00m },
                // Bebidas
                new Dish { Id = 7, Name = "Limonada", Category = InMemoryDB.Categories[3], Price = 4.50m },
                new Dish { Id = 8, Name = "Café Americano", Category = InMemoryDB.Categories[3], Price = 3.00m },
            });

            // Inicializar la aplicación
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
