using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PoppelOrderingSystem.Database_Layer;
using PoppelOrderingSystem.Business_Layer;

namespace PoppelOrderingSystem.Presentation_Layer
{
    public partial class OrderForm : Form
    {
        #region Variables

        private Customer customer;
        private CustomerController customerController;

        #endregion
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomerRegistration form = new frmCustomerRegistration();
            this.Hide();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            string custNo = txtCustomerNo.Text;

            if (custNo == "" || custNo.Length <10){
                MessageBox.Show("Customer Number field cannot be empty or less than 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                    customerController = new CustomerController();
                    customer = customerController.Find(custNo);

                if (customerController.Found == false)
                {
                    MessageBox.Show("Customer not found. Create new customer.", "Check Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCreateNewCustomer.Enabled = true;

                }
                else
                {

                    MessageBox.Show("Customer found!", "Check Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (customer.creditStatus == "On Hold")
                    {

                        MessageBox.Show("Credit Status is On Hold, unable to proceed with order.", "Customer Credit Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDisplayCustNo.Text = custNo;
                        txtDisplayCredStat.Text = "On Hold";
                    }
                    else
                    {
                        MessageBox.Show("Credit Status is Released, you may proceed with order.", "Customer Credit Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDisplayCustNo.Text = custNo;
                        txtDisplayCredStat.Text = "Released";
                        btnProceed.Enabled = true;
                    }
                }

            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            btnAddNewItem.Enabled = true;
        }
    }
    }

