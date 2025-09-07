using ChefControl.Views;

namespace ChefControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UserButtonImage_Click(object sender, EventArgs e)
        {
            UserOrderForm userOrderForm = new UserOrderForm();
            this.Hide();
            userOrderForm.ShowDialog();
            this.Show();
        }

        private void AdminUserButtonImage_Click(object sender, EventArgs e)
        {
            AdminManageForm adminManageForm = new AdminManageForm();
            this.Hide();
            adminManageForm.ShowDialog();
            this.Show();
        }
    }
}
