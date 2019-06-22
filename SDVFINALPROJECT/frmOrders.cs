using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDVFINALPROJECT
{
    public partial class frmOrders : Form
    {
        private frmDeviceType Products;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Products = new frmDeviceType();
            Products.Show();
        }

        private void frmMobileDevices_Load(object sender, EventArgs e)
        {

        }
    }
}
