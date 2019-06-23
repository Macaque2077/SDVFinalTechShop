using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public sealed partial class frmDeviceType : Form
    {
        public static frmDeviceType Instance { get { return frmDeviceType.instance; } } // this is the public property

        private static readonly frmDeviceType instance = new frmDeviceType();

        private static Dictionary<string, frmDeviceType> _DeviceTypeFormList = new Dictionary<string, frmDeviceType>();

        private clsDeviceType _DeviceType;

        private frmDeviceType()
        {
           InitializeComponent();
        }

        public static void Run(string prDeviceType)
        {
            frmDeviceType lcDeviceTypeForm;
            if (string.IsNullOrEmpty(prDeviceType) ||
            !_DeviceTypeFormList.TryGetValue(prDeviceType, out lcDeviceTypeForm))
            {
                lcDeviceTypeForm = new frmDeviceType();
                if (string.IsNullOrEmpty(prDeviceType))
                    lcDeviceTypeForm.SetDetails(new clsDeviceType());
                else
                {
                    _DeviceTypeFormList.Add(prDeviceType, lcDeviceTypeForm);
                    lcDeviceTypeForm.refreshFormFromDB(prDeviceType);
                }
            }
            else
            {
                lcDeviceTypeForm.Show();
                lcDeviceTypeForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prDeviceType)
        {
            SetDetails(await ServiceClient.GetDeviceTypeAsync(prDeviceType));

            
        }
        

        private void SetDetails(clsDeviceType prDeviceType)
        {
            _DeviceType = prDeviceType;
            updateForm();
            UpdateDisplay();
            Show();
            frmHome.Instance.updateDisplay();
            txtName.Enabled = string.IsNullOrEmpty(_DeviceType.Name);
            
        }

        private void updateForm()
        {

            txtName.Text = _DeviceType.Name;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct.DispatchProductForm(lstProducts.SelectedValue as clsAllProducts);

        }
        private void UpdateDisplay()
        {
            lstProducts.DataSource = null;
            if (_DeviceType.ProductsList != null)
                lstProducts.DataSource = _DeviceType.ProductsList;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new InputBox(clsAllProducts.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply)) 
                {
                    clsAllProducts lcProduct = clsAllProducts.NewProduct(lcReply[0]);
                    if (lcProduct != null) 
                    { 

                        if (txtName.Enabled)       
                        {
                            pushData();
                            await ServiceClient.InsertProductAsync(_DeviceType);
                            txtName.Enabled = false;
                        }
                        lcProduct.DeviceTypeName = _DeviceType.Name;
                        frmProduct.DispatchProductForm(lcProduct);
                        if (!string.IsNullOrEmpty(lcProduct.ProductName)) 
                        {
                            refreshFormFromDB(_DeviceType.Name);
                            frmHome.Instance.updateDisplay();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateDisplay();
            frmHome.Instance.updateDisplay();
        }

        private async void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                pushData();
                if (txtName.Enabled)
                {
                    MessageBox.Show(await ServiceClient.InsertDeviceTypeAsync(_DeviceType));
                    frmHome.Instance.updateDisplay();
                    txtName.Enabled = false;
                }
                else
                    MessageBox.Show(await ServiceClient.UpdateDeviceTypeAsync(_DeviceType));
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pushData()
        {
            _DeviceType.Name = txtName.Text;

        }


        private void lstProducts_DoubleClick(object sender, MouseEventArgs e)
        {
            frmProduct.DispatchProductForm(lstProducts.SelectedValue as clsAllProducts);
            UpdateDisplay();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            int lcIndex = lstProducts.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteProductAsync(lstProducts.SelectedItem as clsAllProducts));
                refreshFormFromDB(_DeviceType.Name);
                frmHome.Instance.updateDisplay();
            }
        }
    }
}
