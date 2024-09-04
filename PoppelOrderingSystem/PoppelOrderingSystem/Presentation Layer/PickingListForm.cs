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
    public partial class PickingListForm : Form
    {
        public PickingListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHomePage form = new frmHomePage();
            this.Hide();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PickingListForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
