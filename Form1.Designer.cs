namespace ChefControl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Maintitle = new Label();
            UserButtonImage = new PictureBox();
            AdminUserButtonImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)UserButtonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminUserButtonImage).BeginInit();
            SuspendLayout();
            // 
            // Maintitle
            // 
            resources.ApplyResources(Maintitle, "Maintitle");
            Maintitle.Name = "Maintitle";
            // 
            // UserButtonImage
            // 
            UserButtonImage.Image = Properties.Resources.orderButtonUser;
            resources.ApplyResources(UserButtonImage, "UserButtonImage");
            UserButtonImage.Name = "UserButtonImage";
            UserButtonImage.TabStop = false;
            UserButtonImage.Click += UserButtonImage_Click;
            // 
            // AdminUserButtonImage
            // 
            AdminUserButtonImage.Image = Properties.Resources.administratorIcon;
            resources.ApplyResources(AdminUserButtonImage, "AdminUserButtonImage");
            AdminUserButtonImage.Name = "AdminUserButtonImage";
            AdminUserButtonImage.TabStop = false;
            AdminUserButtonImage.Click += AdminUserButtonImage_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminUserButtonImage);
            Controls.Add(UserButtonImage);
            Controls.Add(Maintitle);
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserButtonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminUserButtonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Maintitle;
        private PictureBox UserButtonImage;
        private PictureBox AdminUserButtonImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
