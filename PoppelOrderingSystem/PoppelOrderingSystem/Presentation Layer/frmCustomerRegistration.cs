using PoppelOrderingSystem.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.Database_Layer;
using System.Xml;

namespace PoppelOrderingSystem
{
    public partial class frmCustomerRegistration : Form
    {
        #region Data Members
        private Customer customer;
        private CustomerController customerController;
        public bool customerFormClosed = false;

        #endregion
        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        public frmCustomerRegistration(CustomerController aController)
        {
            InitializeComponent();
            customerController = aController;
        }

        #region Utility Methods
        private void ClearAll() {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtCustomerNo.Text = "";
            radiobtnOnHold.Checked = false;
            radiobtnReleased.Checked = false;
        }

        private void PopulateObject() {

            customer = new Customer();
            customer.Email = txtEmail.Text;
            customer.Id = txtID.Text;
            customer.PhoneNumber = txtPhone.Text;
            customer.customerNumber = txtCustomerNo.Text;
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.CreditBalance = float.Parse(txtCreditBalance.Text);

            if (radiobtnOnHold.Checked == true)
            {
                customer.creditStatus = radiobtnOnHold.Text;
            }
            else {
                if (radiobtnReleased.Checked == true) { 
                    customer.creditStatus = radiobtnReleased.Text;
                }
            }
        }
        #endregion
        private void frmCustomerRegistration_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ShowAll(true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerRegistration_Activated(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void ShowAll(bool value)
        {
            lblID.Visible = value;
            lblName.Visible = value;
            lblPhone.Visible = value;
            lblEmail.Visible = value;
            lblCustomerNo.Visible = value;
            lblCreditStatus.Visible = value;
            lblAddress.Visible = value;
            label2.Visible = value;
            label1.Visible = value;
            lblCredBalance.Visible = value;
            txtCreditBalance.Visible = value;
            txtAddress.Visible = value;
            txtCustomerNo.Visible = value;
            txtEmail.Visible = value;
            txtID.Visible = value;
            txtName.Visible = value;
            btnAddCustomer.Visible = value;
            btnGenerateCustomerNo.Visible = value;
            //btnHome.Visible = value;
            
            
            if (!(value))
            {
                radiobtnOnHold.Checked = false;
                radiobtnReleased.Checked = false;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void btnGenerateCustomerNo_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String ID = txtID.Text;
            String letters = "";
            String IDnums = "";

            //Check Input Correctness and Extract letters and digits for CustomerNo from ID and Name
            if (ID == "" || ID.Length < 13)
            {
                MessageBox.Show("ID cannot be empty or less than 13 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (name == "")
                {
                    MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    letters = letters + name.Substring(0, 2);
                    IDnums = IDnums + ID.Substring(ID.Length - 4);


                    //Generate Random last four digits
                    Random r = new Random();
                    int nums = r.Next(1000, 9999);

                    //Display Customer Number generated
                    txtCustomerNo.Text = letters + IDnums + nums;

                    //Enable Add Customer button
                    btnAddCustomer.Enabled = true;
                }
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Check Input Correctness
            if (txtPhone.Text == "" || txtPhone.TextLength < 10)
            {
                MessageBox.Show("Phone Number cannot be empty or less than 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (txtAddress.Text == "" || radiobtnOnHold.Checked == false & radiobtnReleased.Checked == false)
                {
                    MessageBox.Show("All required fields need to be filled. Make sure Address and Credit Status are not empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    PopulateObject();
                    customerController = new CustomerController();
                    customerController.DataMaintenance(customer, DBClass.DBOperation.Add);
                    customerController.FinalizeChanges(customer);
                    MessageBox.Show("Customer added successfully!", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    ShowAll(false);
                }
            }

            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only numbers
            if (!char.IsNumber(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only numbers
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only letters
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
