using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public partial class frmDeviceType : Form
    {
        private static Dictionary<string, frmDeviceType> _DeviceTypeFormList = new Dictionary<string, frmDeviceType>();

        private clsDeviceType _DeviceType;
        //private frmEditProd EditProd;
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

            //throw new NotImplementedException();
        }

        //Task3 5b vii needed for setDetails
        

        private void SetDetails(clsDeviceType prDeviceType)
        {
            _DeviceType = prDeviceType;
            updateForm();
            UpdateDisplay();
            Show();
            frmHome.Instance.updateDisplay();
            txtName.Enabled = string.IsNullOrEmpty(_DeviceType.Name);
            //throw new NotImplementedException();
        }

        private void updateForm()
        {

            txtName.Text = _DeviceType.Name;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct.DispatchProductForm(lstProducts.SelectedValue as clsAllProducts);
            //EditProd = new frmEditProd();
            //EditProd.Show();
        }
        private void UpdateDisplay()
        {
            lstProducts.DataSource = null;
            if (_DeviceType.ProductsList != null)
                lstProducts.DataSource = _DeviceType.ProductsList;
        }
        public virtual Boolean isValid()
        {
            return true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new InputBox(clsAllProducts.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
                {
                    clsAllProducts lcProduct = clsAllProducts.NewProduct(lcReply[0]);
                    if (lcProduct != null) // valid artwork created?
                    { 

                        if (txtName.Enabled)       // new artist not saved?
                        {
                            pushData();
                            await ServiceClient.InsertProductAsync(_DeviceType);
                            txtName.Enabled = false;
                        }
                        lcProduct.DeviceTypeName = _DeviceType.Name;
                        frmProduct.DispatchProductForm(lcProduct);
                        if (!string.IsNullOrEmpty(lcProduct.ProductName)) // not cancelled?
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

        private void frmListProducts_Load(object sender, EventArgs e)
        {

        }

        private void lstDeviceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
