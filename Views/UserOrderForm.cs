using ChefControl.Data;
using ChefControl.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ChefControl.Views
{
    public partial class UserOrderForm : Form
    {
        public UserOrderForm()
        {
            InitializeComponent();
            categoriesFood.Items.AddRange(InMemoryDB.Categories.Select(c => c.Name).ToArray());
            categoriesFood.SelectedIndexChanged += CategoriesFood_SelectedIndexChanged;
        }

        private void CategoriesFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryName = categoriesFood.SelectedItem?.ToString();

            if (selectedCategoryName != null)
            {
                var dishesInCategory = InMemoryDB.Dishes
                    .Where(dish => dish.Category.Name == selectedCategoryName)
                    .ToList();

                dishesOptionsByCategory.DataSource = dishesInCategory;
                dishesOptionsByCategory.DisplayMember = "Name";
            }
        }
    }
}
