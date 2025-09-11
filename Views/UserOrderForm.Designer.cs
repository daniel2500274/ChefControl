using ChefControl.Data;

namespace ChefControl.Views
{
    partial class UserOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderForm));
            imageList1 = new ImageList(components);
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            categoriesFood = new ComboBox();
            label3 = new Label();
            dishesOptionsByCategory = new ListBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "administratorIcon.png");
            imageList1.Images.SetKeyName(1, "orderButtonUser.png");
            imageList1.Images.SetKeyName(2, "restaurantIcon.ico");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 0;
            label1.Text = "Menu 🛎️";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 94);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(534, 434);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 553);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 2;
            label2.Text = "Purchase Total   Total Items";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(769, 553);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 3;
            button1.Text = "Confirm Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // categoriesFood
            // 
            categoriesFood.FormattingEnabled = true;
            categoriesFood.Location = new Point(12, 94);
            categoriesFood.Name = "categoriesFood";
            categoriesFood.Size = new Size(297, 28);
            categoriesFood.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 5;
            label3.Text = "Food Categories";
            // 
            // dishesOptionsByCategory
            // 
            dishesOptionsByCategory.FormattingEnabled = true;
            dishesOptionsByCategory.Location = new Point(12, 164);
            dishesOptionsByCategory.Name = "dishesOptionsByCategory";
            dishesOptionsByCategory.Size = new Size(324, 304);
            dishesOptionsByCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 7;
            label4.Text = "Select your food:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(556, 61);
            label5.Name = "label5";
            label5.Size = new Size(176, 28);
            label5.TabIndex = 8;
            label5.Text = "Order sumary 📑";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Location = new Point(13, 541);
            button2.Name = "button2";
            button2.Size = new Size(136, 35);
            button2.TabIndex = 9;
            button2.Text = "Add to order";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 501);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "Cantidad";
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Location = new Point(200, 541);
            button3.Name = "button3";
            button3.Size = new Size(136, 35);
            button3.TabIndex = 11;
            button3.Text = "Del from order";
            button3.UseVisualStyleBackColor = false;
            // 
            // UserOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dishesOptionsByCategory);
            Controls.Add(label3);
            Controls.Add(categoriesFood);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserOrderForm";
            Text = "UserOrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private ComboBox categoriesFood;
        private Label label3;
        private ListBox dishesOptionsByCategory;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
    }
}