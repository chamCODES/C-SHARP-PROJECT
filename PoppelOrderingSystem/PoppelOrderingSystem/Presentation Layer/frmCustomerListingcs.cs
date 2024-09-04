using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Business_Layer;
using PoppelOrderingSystem.Database_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml;


namespace PoppelOrderingSystem.Presentation_Layer
{
    public partial class frmCustomerListing : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<Customer> customers;
        private CustomerController customerController;
        private FormStates state;
        private Customer customer;
        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion

       
        public frmCustomerListing(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
            this.Load += frmCustomerListing_Load;
            this.Activated += frmCustomerListing_Activated;
            state = FormStates.View;
        }

        private void frmCustomerListing_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listViewCustomers.View = View.Details;
        }

        #region The List View
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;   //Declare variables

            //Clear current List View Control
            listViewCustomers.Clear();

            //Set Up Columns of List View
            listViewCustomers.Columns.Insert(0, "CustomerNo", 100, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(1, "ID", 120, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(2, "Name", 150, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(3, "Email", 180, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(4, "Phone Number", 200, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(5, "Address", 230, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(6, "Credit Status", 260, HorizontalAlignment.Left);
            listViewCustomers.Columns.Insert(7, "Credit Balance", 290, HorizontalAlignment.Left);

            customers = null;

            customers = customerController.AllCustomers;

            //Add customer details to each ListView item 
            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.customerNumber.ToString();
                customerDetails.SubItems.Add(customer.Id);
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Email);
                customerDetails.SubItems.Add(customer.PhoneNumber);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add(customer.creditStatus);
                customerDetails.SubItems.Add(customer.CreditBalance.ToString());

                listViewCustomers.Items.Add(customerDetails);
            }

            listViewCustomers.Refresh();
            listViewCustomers.GridLines = true;
        }
        #endregion

        #region Form Events
        private void frmCustomerListing_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void frmCustomerListing_Activated(object sender, EventArgs e)
        {
            listViewCustomers.View = View.Details;
            setUpCustomerListView();
            ShowAll(false);

        }

        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            lblID.Visible = value;
            lblCustomerNo.Visible = value;
            lblName.Visible = value;
            lblPhone.Visible = value;
            lblEmail.Visible = value;
            lblCreditStatus.Visible = value;
            lblCredBal.Visible = value;

            //If the form state is View, the Submit button should not be visible
            if (state == FormStates.Delete)
            {
                btnSubmit.Visible = !value;
                btnCancel.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
            btnEdit.Visible = value;
            btnDelete.Visible = value;

        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtCustomerNo.Enabled = !value;
                txtID.Enabled = !value;
            }
            else
            {
                txtCustomerNo.Enabled = value;
                txtID.Enabled = value;
            }
            txtName.Enabled = value;
            txtEmail.Enabled = value;
            txtPhone.Enabled = value;
            txtAddress.Enabled = value;
            txtCreditStatus.Enabled = value;
            txtCredBal.Enabled = value;

            if (state == FormStates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
        }
        private void ClearAll()
        {
            txtAddress.Text = "";
            txtCredBal.Text = "";
            txtCreditStatus.Text = "";
            txtCustomerNo.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

        }
        private void PopulateTextBoxes(Customer cust)
        {
            txtID.Text = cust.Id;
            txtCustomerNo.Text = cust.customerNumber;
            txtName.Text = cust.Name;
            txtEmail.Text = cust.Email;
            txtPhone.Text = cust.PhoneNumber;
            txtCreditStatus.Text = cust.creditStatus;
            txtAddress.Text = cust.Address;
            txtCredBal.Text = cust.CreditBalance.ToString();

        }

        private void PopulateObject()
        {
            customer = new Customer();
            customer.Id = txtID.Text;
            customer.customerNumber = txtCustomerNo.Text;
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.PhoneNumber = txtPhone.Text;
            customer.Address = txtAddress.Text;
            customer.creditStatus = txtCreditStatus.Text;
            customer.CreditBalance = float.Parse(txtCredBal.Text);

        }

        #endregion

        private void employeeListViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (listViewCustomers.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = customerController.Find(listViewCustomers.SelectedItems[0].Text);  //selected customer becomes current customer

                PopulateTextBoxes(customer);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {                           

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Edit)
            {
                customerController.DataMaintenance(customer, DBClass.DBOperation.Edit);

            }
            else
            //delete code
            {
                customerController.DataMaintenance(customer, DBClass.DBOperation.Delete);
            }
            customerController.FinalizeChanges(customer);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            //set the form state to Edit
            state = FormStates.Edit;
            EnableEntries(true);//call the EnableEntities method
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //set the form state to Delete
            state = FormStates.Delete;
            btnEdit.Visible = false;
            EnableEntries(false);
            MessageBox.Show("This record is about to be deleted.", "Customer Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();  //refresh List View

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    