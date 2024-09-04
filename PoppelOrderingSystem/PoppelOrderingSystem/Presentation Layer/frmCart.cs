using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderingSystem.Presentation_Layer
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void frmHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
