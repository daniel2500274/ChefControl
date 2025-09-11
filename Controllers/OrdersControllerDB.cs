using ChefControl.Data;
using ChefControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChefControl.Controllers
{
    public sealed class ChefController
    {
        // Dish Methods
        public BindingList<Dish> GetAllDishes() => new(InMemoryDB.Dishes);

        public void CreateDish(int id, string name, Category category, decimal price)
        {
            if (InMemoryDB.Dishes.Any(d => d.Id == id))
                throw new ArgumentException("A dish with this Id already exists.");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Dish name cannot be empty.");
            if (!InMemoryDB.Categories.Any(c => c.Id == category.Id))
                throw new ArgumentException("The specified category does not exist.");
            if (price <= 0)
                throw new ArgumentException("Price must be a positive value.");

            var newDish = new Dish { Id = id, Name = name, Category = category, Price = price };
            InMemoryDB.Dishes.Add(newDish);
        }

        public Dish GetDishById(int id)
        {
            var dish = InMemoryDB.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish == null)
                throw new ArgumentException("Dish not found.");
            return dish;
        }

        public void UpdateDish(int id, string name, Category category, decimal price)
        {
            var dish = GetDishById(id);
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Dish name cannot be empty.");
            if (!InMemoryDB.Categories.Any(c => c.Id == category.Id))
                throw new ArgumentException("The specified category does not exist.");
            if (price <= 0)
                throw new ArgumentException("Price must be a positive value.");

            dish.Name = name;
            dish.Category = category;
            dish.Price = price;
        }

        public void DeleteDish(int id)
        {
            var dish = GetDishById(id);
            InMemoryDB.Dishes.Remove(dish);
        }

        // Category Methods
        public BindingList<Category> GetAllCategories() => new(InMemoryDB.Categories);

        public void CreateCategory(int id, string name)
        {
            if (InMemoryDB.Categories.Any(c => c.Id == id))
                throw new ArgumentException("A category with this Id already exists.");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.");

            var newCategory = new Category { Id = id, Name = name };
            InMemoryDB.Categories.Add(newCategory);
        }

        public Category GetCategoryById(int id)
        {
            var category = InMemoryDB.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                throw new ArgumentException("Category not found.");
            return category;
        }

        public void UpdateCategory(int id, string name)
        {
            var category = GetCategoryById(id);
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.");

            category.Name = name;
        }

        public void DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            InMemoryDB.Categories.Remove(category);
        }

        // Order Methods
        public BindingList<Order> GetAllOrders() => new(InMemoryDB.Orders);

        public void CreateOrder(int id, Dish dish, int numberOfDishes, decimal subtotal)
        {
            if (InMemoryDB.Orders.Any(o => o.Id == id))
                throw new ArgumentException("An order with this Id already exists.");
            if (!InMemoryDB.Dishes.Any(d => d.Id == dish.Id))
                throw new ArgumentException("The specified dish does not exist.");
            if (numberOfDishes <= 0)
                throw new ArgumentException("Number of dishes must be a positive value.");
            if (subtotal <= 0)
                throw new ArgumentException("Subtotal must be a positive value.");

            var newOrder = new Order { Id = id, Dish = dish, numberOfDishes = numberOfDishes, Subtotal = subtotal };
            InMemoryDB.Orders.Add(newOrder);
        }

        public Order GetOrderById(int id)
        {
            var order = InMemoryDB.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
                throw new ArgumentException("Order not found.");
            return order;
        }

        public void UpdateOrder(int id, Dish dish, int numberOfDishes, decimal subtotal)
        {
            var order = GetOrderById(id);
            if (!InMemoryDB.Dishes.Any(d => d.Id == dish.Id))
                throw new ArgumentException("The specified dish does not exist.");
            if (numberOfDishes <= 0)
                throw new ArgumentException("Number of dishes must be a positive value.");
            if (subtotal <= 0)
                throw new ArgumentException("Subtotal must be a positive value.");

            order.Dish = dish;
            order.numberOfDishes = numberOfDishes;
            order.Subtotal = subtotal;
        }

        public void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            InMemoryDB.Orders.Remove(order);
        }

        // OrderBill Methods
        public BindingList<OrderBill> GetAllOrderBills() => new(InMemoryDB.OrderBill);

        public void CreateOrderBill(int idBill, DateTime dateBill, List<Order> detailsBill, decimal total)
        {
            if (InMemoryDB.OrderBill.Any(b => b.IdBill == idBill))
                throw new ArgumentException("An order bill with this Id already exists.");
            if (detailsBill == null || !detailsBill.Any())
                throw new ArgumentException("Order bill must have at least one order.");
            if (total <= 0)
                throw new ArgumentException("Total must be a positive value.");

            var newOrderBill = new OrderBill { IdBill = idBill, DateBill = dateBill, DetailsBill = detailsBill, Total = total };
            InMemoryDB.OrderBill.Add(newOrderBill);
        }

        public OrderBill GetOrderBillById(int idBill)
        {
            var orderBill = InMemoryDB.OrderBill.FirstOrDefault(b => b.IdBill == idBill);
            if (orderBill == null)
                throw new ArgumentException("Order bill not found.");
            return orderBill;
        }

        public void UpdateOrderBill(int idBill, DateTime dateBill, List<Order> detailsBill, decimal total)
        {
            var orderBill = GetOrderBillById(idBill);
            if (detailsBill == null || !detailsBill.Any())
                throw new ArgumentException("Order bill must have at least one order.");
            if (total <= 0)
                throw new ArgumentException("Total must be a positive value.");

            orderBill.DateBill = dateBill;
            orderBill.DetailsBill = detailsBill;
            orderBill.Total = total;
        }

        public void DeleteOrderBill(int idBill)
        {
            var orderBill = GetOrderBillById(idBill);
            InMemoryDB.OrderBill.Remove(orderBill);
        }
    }
}
