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
    public sealed partial class frmHome : Form
    {
        private static readonly frmHome _Instance = new frmHome();

        public static frmHome Instance
        {
            get { return frmHome._Instance; }
        }

        private frmOrders MobileDevices;
        private frmDeviceType Products;
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDeviceTypes.Items.Add("Smart watches");
            lstDeviceTypes.Items.Add("Phones");
            lstDeviceTypes.Items.Add("Tablets");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MobileDevices = new frmOrders();
            MobileDevices.Show();
        }

        private void lblBrands_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lstDeviceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
