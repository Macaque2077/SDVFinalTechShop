using System;
using System.Collections.Generic;
using System.Linq;
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

        //load a new or used product based on the char U or N
        public delegate void LoadWorkFormDelegate(clsAllProducts prProduct);

        public static Dictionary<char, Delegate> _ProductsForm = new Dictionary<char, Delegate>
        {
            {'U', new LoadWorkFormDelegate(frmProductUsed.Run)},
            {'N', new LoadWorkFormDelegate(frmProductNew.Run)},
        };

        //calls the load and sends the Char U or N
        public static void DispatchProductForm(clsAllProducts prProduct)
        {
            _ProductsForm[prProduct.NewOrUsed].DynamicInvoke(prProduct);
        }

        //pushes the changes to the form to the database after performing checks
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (QuanityandPricePositive() == true && inputValid() == true)
            {
                pushData();
                //DialogResult = DialogResult.OK; Q10
                //if (inputValid() == true)
                //{

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
                
            }
        }
        //checks whether the text box values are valid returns a bool
        private bool inputValid()
        {
            bool lcValid = false;

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text)  || string.IsNullOrEmpty(tb.Text))
                {
                        lcValid = false;
                        MessageBox.Show("Cannot enter whitespace or null for fields");
                        break;

                }
                else
                {
                    lcValid = true;
                }
            }
            return lcValid;
            
        }
        //checks whether positives have been entered for quantity and price
        private bool QuanityandPricePositive()
        {
            try
            {
                if (int.Parse(tbStockQuantity.Text) > 0 && decimal.Parse(tbPricePI.Text) > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Quantity and price must be greater than 0");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Quantity and price cannot be empty");
                return false;
            }


        }


    }
}
