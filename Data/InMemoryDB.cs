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
        public static List<OrderBill> OrderBill = new List<OrderBill>();
        public static List<Dish> Dishes { get; } = new List<Dish>();
        public static List<Category> Categories{ get; } = new List<Category>();
        public static List<Order> Orders { get; } = new List<Order>(); 
    }
}
