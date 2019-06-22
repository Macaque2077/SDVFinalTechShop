using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public sealed partial class frmHome : Form
    {
        public static frmHome Instance { get { return frmHome.instance; } } // this is the public property

        private static readonly frmHome instance = new frmHome();

        public frmHome()
        {
            InitializeComponent();
        }

        //private frmOrders MobileDevices;
        //private frmListProducts Products;


        private void Form1_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }
        public async void updateDisplay()
        {
            try
            {
                lstbxDeviceTypes.DataSource = null;
                lstbxDeviceTypes.DataSource = await ServiceClient.GetDeviceTypesNamesAsync();
            }
            catch { }
        }
            private void btnEdit_Click(object sender, EventArgs e)
        {
            
            //MobileDevices = new frmOrders();
            //MobileDevices.Show();
        }

        private void lblBrands_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeviceType.Run(null);
                

            }
            catch (Exception)
            {

                MessageBox.Show("Duplicate Key!");
            }
        }
        private void lstbxDeviceTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstbxDeviceTypes.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmDeviceType.Run(lstbxDeviceTypes.SelectedItem as string);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sorry no Product by this name");
                }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstbxDeviceTypes.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmDeviceType.Run(lstbxDeviceTypes.SelectedItem as string);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sorry no artist by this name");
                }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrders.Run();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sorry error opening orders");
            }
        }
    }
}
