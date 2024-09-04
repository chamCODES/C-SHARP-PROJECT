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
    public partial class frmCatalogue : Form
    {
        public frmCatalogue()
        {
            InitializeComponent();
        }

        private void frmCatalogue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCatalogue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
