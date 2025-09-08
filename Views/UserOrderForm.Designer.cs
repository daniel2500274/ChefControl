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
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Menu 🛎️";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(467, 344);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 415);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 2;
            label2.Text = "Purchase Total   Total Items";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(673, 415);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 3;
            button1.Text = "Confirm Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
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
    }
}