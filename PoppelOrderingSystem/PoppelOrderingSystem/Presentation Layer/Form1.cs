using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem;

namespace PoppelOrderingSystem
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to cancel operation?", "Cancel Log In", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {}
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (username == "Marketing Clerk" || username == "marketing clerk" & password == "010_PoppelMC##")
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Your Log In was successful! Press OK to continue.", "Log In Successful", button, MessageBoxIcon.Information);

                frmHomePage form = new frmHomePage();
                this.Hide();
                form.Show();
                
            }

            else {

                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Username or Password incorrect. Please enter correct details.", "Log In Unsuccessful", button, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Clear();

            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
