using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }
        //loads device type names from DB and populates listbox
        public async void updateDisplay()
        {
            try
            {
                lstbxDeviceTypes.DataSource = null;
                lstbxDeviceTypes.DataSource = await ServiceClient.GetDeviceTypesNamesAsync();
            }
            catch { }
        }

        //opens the product list for the selected device type
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

        //closes form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //also opens product list form, could not assign both clicks to same function
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

        //opens orders form
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
