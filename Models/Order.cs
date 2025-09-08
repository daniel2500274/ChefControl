using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefControl.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Dish Dish { get; set; }
        public int numberOfDishes { get; set; }
        public decimal Subtotal { get; set; }
    }
}
