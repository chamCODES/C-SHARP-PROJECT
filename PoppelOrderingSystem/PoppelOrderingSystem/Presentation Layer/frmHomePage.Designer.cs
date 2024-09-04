namespace PoppelOrderingSystem
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.userIconHome = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.btnViewCatalogue = new System.Windows.Forms.Button();
            this.btnUpdateCatalogue = new System.Windows.Forms.Button();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrderDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpiredProducts = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCustomerListing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Location = new System.Drawing.Point(860, 11);
            this.linkLabelLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(74, 22);
            this.linkLabelLogOut.TabIndex = 0;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // LogoHome
            // 
            this.LogoHome.Image = ((System.Drawing.Image)(resources.GetObject("LogoHome.Image")));
            this.LogoHome.Location = new System.Drawing.Point(15, 17);
            this.LogoHome.Margin = new System.Windows.Forms.Padding(4);
            this.LogoHome.Name = "LogoHome";
            this.LogoHome.Size = new System.Drawing.Size(188, 120);
            this.LogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoHome.TabIndex = 1;
            this.LogoHome.TabStop = false;
            // 
            // userIconHome
            // 
            this.userIconHome.Image = ((System.Drawing.Image)(resources.GetObject("userIconHome.Image")));
            this.userIconHome.Location = new System.Drawing.Point(844, 37);
            this.userIconHome.Margin = new System.Windows.Forms.Padding(4);
            this.userIconHome.Name = "userIconHome";
            this.userIconHome.Size = new System.Drawing.Size(108, 83);
            this.userIconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIconHome.TabIndex = 2;
            this.userIconHome.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(841, 124);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(128, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Marketing Clerk";
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Location = new System.Drawing.Point(15, 231);
            this.btnRegisterCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(212, 48);
            this.btnRegisterCustomer.TabIndex = 4;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.btnRegisterCustomer_Click);
            // 
            // btnViewCatalogue
            // 
            this.btnViewCatalogue.Location = new System.Drawing.Point(15, 303);
            this.btnViewCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCatalogue.Name = "btnViewCatalogue";
            this.btnViewCatalogue.Size = new System.Drawing.Size(212, 48);
            this.btnViewCatalogue.TabIndex = 5;
            this.btnViewCatalogue.Text = "View Catalogue";
            this.btnViewCatalogue.UseVisualStyleBackColor = true;
            this.btnViewCatalogue.Click += new System.EventHandler(this.btnViewCatalogue_Click);
            // 
            // btnUpdateCatalogue
            // 
            this.btnUpdateCatalogue.Location = new System.Drawing.Point(15, 372);
            this.btnUpdateCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCatalogue.Name = "btnUpdateCatalogue";
            this.btnUpdateCatalogue.Size = new System.Drawing.Size(212, 48);
            this.btnUpdateCatalogue.TabIndex = 6;
            this.btnUpdateCatalogue.Text = "Update Catalogue";
            this.btnUpdateCatalogue.UseVisualStyleBackColor = true;
            this.btnUpdateCatalogue.Click += new System.EventHandler(this.btnUpdateCatalogue_Click);
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Location = new System.Drawing.Point(15, 445);
            this.btnStartOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(212, 48);
            this.btnStartOrder.TabIndex = 7;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // btnUpdateOrderDetails
            // 
            this.btnUpdateOrderDetails.Location = new System.Drawing.Point(15, 514);
            this.btnUpdateOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateOrderDetails.Name = "btnUpdateOrderDetails";
            this.btnUpdateOrderDetails.Size = new System.Drawing.Size(212, 48);
            this.btnUpdateOrderDetails.TabIndex = 8;
            this.btnUpdateOrderDetails.Text = "Update Order Details";
            this.btnUpdateOrderDetails.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetails.Click += new System.EventHandler(this.btnUpdateOrderDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExpiredProducts);
            this.panel1.Controls.Add(this.btnMonthlySales);
            this.panel1.Location = new System.Drawing.Point(708, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 165);
            this.panel1.TabIndex = 9;
            // 
            // btnExpiredProducts
            // 
            this.btnExpiredProducts.Location = new System.Drawing.Point(32, 98);
            this.btnExpiredProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpiredProducts.Name = "btnExpiredProducts";
            this.btnExpiredProducts.Size = new System.Drawing.Size(212, 48);
            this.btnExpiredProducts.TabIndex = 11;
            this.btnExpiredProducts.Text = "Expired Products";
            this.btnExpiredProducts.UseVisualStyleBackColor = true;
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.Location = new System.Drawing.Point(32, 22);
            this.btnMonthlySales.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Size = new System.Drawing.Size(212, 48);
            this.btnMonthlySales.TabIndex = 11;
            this.btnMonthlySales.Text = "Monthly Sales";
            this.btnMonthlySales.UseVisualStyleBackColor = true;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(704, 231);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(105, 24);
            this.lblReports.TabIndex = 10;
            this.lblReports.Text = "REPORTS";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(740, 445);
            this.btnViewCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(212, 48);
            this.btnViewCart.TabIndex = 11;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(366, 545);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(212, 48);
            this.btnExitApp.TabIndex = 13;
            this.btnExitApp.Text = "Exit Application";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "WELCOME TO POPPEL ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "ORDERING SYSTEM!";
            // 
            // btnCustomerListing
            // 
            this.btnCustomerListing.Location = new System.Drawing.Point(746, 514);
            this.btnCustomerListing.Name = "btnCustomerListing";
            this.btnCustomerListing.Size = new System.Drawing.Size(206, 48);
            this.btnCustomerListing.TabIndex = 16;
            this.btnCustomerListing.Text = "Customer Listing";
            this.btnCustomerListing.UseVisualStyleBackColor = true;
            this.btnCustomerListing.Click += new System.EventHandler(this.btnCustomerListing_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.btnCustomerListing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateOrderDetails);
            this.Controls.Add(this.btnStartOrder);
            this.Controls.Add(this.btnUpdateCatalogue);
            this.Controls.Add(this.btnViewCatalogue);
            this.Controls.Add(this.btnRegisterCustomer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.userIconHome);
            this.Controls.Add(this.LogoHome);
            this.Controls.Add(this.linkLabelLogOut);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.PictureBox LogoHome;
        private System.Windows.Forms.PictureBox userIconHome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Button btnViewCatalogue;
        private System.Windows.Forms.Button btnUpdateCatalogue;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Button btnUpdateOrderDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExpiredProducts;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCustomerListing;
    }
}