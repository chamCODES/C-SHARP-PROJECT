using PoppelOrderingSystem.Business_Layer;
using PoppelOrderingSystem.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderingSystem
{
    public partial class frmHomePage : Form
    {
        private CustomerController customerController;
        private frmCustomerRegistration form;
        frmCustomerListing Listingform;

        public frmHomePage()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                frmLogIn form = new frmLogIn();
                this.Hide();
                form.Show();
            }
            else { }
            
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            form = new frmCustomerRegistration(customerController);
            this.Hide();
            form.Show();
        }

        private void btnViewCatalogue_Click(object sender, EventArgs e)
        {
            frmCatalogue form = new frmCatalogue();
            this.Hide();
            form.Show();
        }

        private void btnUpdateCatalogue_Click(object sender, EventArgs e)
        {
            frmCatalogue form = new frmCatalogue();
            this.Hide();
            form.Show();
        }

        private void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            frmUpdateOrderDetails form = new frmUpdateOrderDetails();
            this.Hide();
            form.Show();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmCart form = new frmCart();
            this.Hide();
            form.Show();
        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            this.Hide();
            form.Show();
        }

        private void btnCustomerListing_Click(object sender, EventArgs e)
        {
             
            this.Hide();

            if (Listingform == null)
            {
                Listingform = new frmCustomerListing(customerController);
            }
            if (Listingform.listFormClosed)
            {
                Listingform = new frmCustomerListing(customerController);
            }
            
            Listingform.setUpCustomerListView();
            Listingform.Show();
        }
    }
}
