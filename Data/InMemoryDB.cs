using ChefControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChefControl.Data
{
    public static class InMemoryDB
    {
        //Initialize a empty list to simulate a DataBase
        private static int _orderId = 0;
        public static List<OrderBill> OrderBill = new();
        public static List<Dish> Dishes { get; } = new();
        public static List<Category> Categories{ get; } = new();
        public static List<Order> Orders { get; } = new(); 
    }
}
