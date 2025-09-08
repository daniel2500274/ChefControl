using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefControl.Models
{
    public class OrderBill
    {
        public int IdBill { get; set; }
        public DateTime DateBill { get; set; }  
        public List<Order> DetailsBill { get; set; }
        public decimal Total { get; set; }
    }
}
