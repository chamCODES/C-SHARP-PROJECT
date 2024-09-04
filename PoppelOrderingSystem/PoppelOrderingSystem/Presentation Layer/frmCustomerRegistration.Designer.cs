namespace PoppelOrderingSystem
{
    partial class frmCustomerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegistration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.radiobtnOnHold = new System.Windows.Forms.RadioButton();
            this.radiobtnReleased = new System.Windows.Forms.RadioButton();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnGenerateCustomerNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCredBalance = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMER REGISTRATION";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(124, 179);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 22);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID: *";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(208, 176);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(216, 29);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 243);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 236);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(26, 305);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(149, 22);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number: *";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(208, 298);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(98, 360);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 353);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 29);
            this.txtEmail.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(78, 415);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 22);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address: *";
            this.lblAddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(208, 408);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 29);
            this.txtAddress.TabIndex = 11;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(39, 475);
            this.lblCreditStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(133, 22);
            this.lblCreditStatus.TabIndex = 12;
            this.lblCreditStatus.Text = "Credit Status: *";
            // 
            // radiobtnOnHold
            // 
            this.radiobtnOnHold.AutoSize = true;
            this.radiobtnOnHold.Location = new System.Drawing.Point(208, 476);
            this.radiobtnOnHold.Name = "radiobtnOnHold";
            this.radiobtnOnHold.Size = new System.Drawing.Size(96, 26);
            this.radiobtnOnHold.TabIndex = 13;
            this.radiobtnOnHold.TabStop = true;
            this.radiobtnOnHold.Text = "On Hold";
            this.radiobtnOnHold.UseVisualStyleBackColor = true;
            // 
            // radiobtnReleased
            // 
            this.radiobtnReleased.AutoSize = true;
            this.radiobtnReleased.Location = new System.Drawing.Point(208, 519);
            this.radiobtnReleased.Name = "radiobtnReleased";
            this.radiobtnReleased.Size = new System.Drawing.Size(100, 26);
            this.radiobtnReleased.TabIndex = 14;
            this.radiobtnReleased.TabStop = true;
            this.radiobtnReleased.Text = "Released";
            this.radiobtnReleased.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(27, 96);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(252, 57);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnGenerateCustomerNo
            // 
            this.btnGenerateCustomerNo.Location = new System.Drawing.Point(642, 179);
            this.btnGenerateCustomerNo.Name = "btnGenerateCustomerNo";
            this.btnGenerateCustomerNo.Size = new System.Drawing.Size(252, 57);
            this.btnGenerateCustomerNo.TabIndex = 16;
            this.btnGenerateCustomerNo.Text = "Generate Customer Number";
            this.btnGenerateCustomerNo.UseVisualStyleBackColor = true;
            this.btnGenerateCustomerNo.Click += new System.EventHandler(this.btnGenerateCustomerNo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCustomerNo);
            this.panel1.Controls.Add(this.txtCustomerNo);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Location = new System.Drawing.Point(615, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 166);
            this.panel1.TabIndex = 17;
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(12, 6);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(159, 22);
            this.lblCustomerNo.TabIndex = 17;
            this.lblCustomerNo.Text = "Customer Number:";
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(27, 43);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.ReadOnly = true;
            this.txtCustomerNo.Size = new System.Drawing.Size(251, 29);
            this.txtCustomerNo.TabIndex = 16;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(643, 475);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(252, 57);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "<< Home Page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(125, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "* means mandatory field";
            // 
            // lblCredBalance
            // 
            this.lblCredBalance.AutoSize = true;
            this.lblCredBalance.Location = new System.Drawing.Point(39, 567);
            this.lblCredBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredBalance.Name = "lblCredBalance";
            this.lblCredBalance.Size = new System.Drawing.Size(144, 22);
            this.lblCredBalance.TabIndex = 20;
            this.lblCredBalance.Text = "Credit Balance: *";
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Location = new System.Drawing.Point(208, 567);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.Size = new System.Drawing.Size(216, 29);
            this.txtCreditBalance.TabIndex = 21;
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 658);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.lblCredBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateCustomerNo);
            this.Controls.Add(this.radiobtnReleased);
            this.Controls.Add(this.radiobtnOnHold);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerRegistration";
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.frmCustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.RadioButton radiobtnOnHold;
        private System.Windows.Forms.RadioButton radiobtnReleased;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnGenerateCustomerNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCredBalance;
        private System.Windows.Forms.TextBox txtCreditBalance;
    }
}