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
    public partial class frmProduct : Form
    {
        protected clsAllProducts _Products;
        public frmProduct()
        {
            InitializeComponent();
        }


        public void SetDetails(clsAllProducts prProduct)
        {
            _Products = prProduct;
            updateForm();
            ShowDialog();

        }

        //private async void btnOK_Click(object sender, EventArgs e)
        //{
        //    if (isValid())
        //    {
        //        //DialogResult = DialogResult.OK; Q10
        //        pushData();
        //        //Task3 6bxviii initiate inserting or updating artworks
        //        //----------------------------------------------------------------------------------------------------------
        //        if (tbProductName.Enabled)
        //            MessageBox.Show(await ServiceClient.InsertProductAsync(_Products));
        //        else
        //            MessageBox.Show(await ServiceClient.UpdateProductAsync(_Products));


        //        Close();
        //    }
        //}
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        //Q10
        protected virtual void updateForm()
        {
            tbProductName.Enabled = string.IsNullOrEmpty(_Products.ProductName);
            tbProductName.Text = _Products.ProductName;
            tbProductCode.Text = _Products.ProductCode;
            tbBrand.Text = _Products.Brand;
            tbPricePI.Text = _Products.PricePerItem.ToString();
            tbStockQuantity.Text = _Products.QuantityInStock.ToString();
            tbLastModified.Text = _Products.DateTimeLastModified.ToShortDateString();
            tbDescription.Text = _Products.ItemDescription;
        }
        protected virtual void pushData()
        {
            try
            {
                _Products.ProductCode = tbProductCode.Text;
                _Products.Brand = tbBrand.Text;
                _Products.ProductName = tbProductName.Text;
                _Products.PricePerItem = decimal.Parse(tbPricePI.Text);
                _Products.QuantityInStock = int.Parse(tbStockQuantity.Text);
                _Products.DateTimeLastModified = DateTime.Now;
                _Products.ItemDescription = tbDescription.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect values entered " +
                    "Price & Quantity should be numbers");
            }

            
        }

        private void frmWork_Load(object sender, EventArgs e)
        {

        }
        //Task3 6xii
        public delegate void LoadWorkFormDelegate(clsAllProducts prProduct);

        public static Dictionary<char, Delegate> _ProductsForm = new Dictionary<char, Delegate>
        {
            {'U', new LoadWorkFormDelegate(frmProductUsed.Run)},
            {'N', new LoadWorkFormDelegate(frmProductNew.Run)},
        };

        public static void DispatchProductForm(clsAllProducts prProduct)
        {
            _ProductsForm[prProduct.NewOrUsed].DynamicInvoke(prProduct);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                //DialogResult = DialogResult.OK; Q10
                if (inputValid() == true)
                {
                    pushData();
                    //Task3 6bxviii initiate inserting or updating artworks
                    //----------------------------------------------------------------------------------------------------------
                    if (tbProductName.Enabled)
                        MessageBox.Show(await ServiceClient.InsertProductAsync(_Products));
                    else
                        MessageBox.Show(await ServiceClient.UpdateProductAsync(_Products));


                    Close();
                }
                else
                {
                    MessageBox.Show("Cannot enter whitespace or null for fields");
                }

            }
        }
        private bool inputValid()
        {
            bool lcResult = false; 

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                {
                    lcResult = false;
                }
                else { lcResult = true; }
            }
            return lcResult;
        }

    }
}
