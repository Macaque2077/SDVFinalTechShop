using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Tech4Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgProduct : Page
    {
        private clsAllProducts _Product;

        private clsOrder _Order;

        private string _ProductCode;
        public pgProduct()
        {
            this.InitializeComponent();
           

        //    _ProductsContent = new Dictionary<char, Delegate>
        //{
        //    {'U', new LoadWorkControlDelegate(RunProductUsed)},
        //    {'N', new LoadWorkControlDelegate(RunProductNew)},
        //};
        }

        //private delegate void LoadWorkControlDelegate(clsAllProducts prProduct);

        //private Dictionary<char, Delegate> _ProductsContent;
        //private void dispatchProductsContent(clsAllProducts prProduct)
        //{
        //    _ProductsContent[prProduct.NewOrUsed].DynamicInvoke(prProduct);
        //    updatePage();
        //}

        private void updatePage()
        {


            //tblProductTitle.Text = (prProduct.ProductName);
            tbProductCode.Text = (_Product.ProductCode);
            tbBrand.Text = (_Product.Brand);
            tbPrice.Text = (_Product.PricePerItem.ToString());
            tbStock.Text = (_Product.QuantityInStock.ToString());

            tbDescription.Text = (_Product.ItemDescription);
            RunNeworUsed();
            //(ctcProdSpecs.Content as IProductControl).UpdateControl(_Product);
        }

        private void RunNeworUsed()
        {
            char New = 'N';

            if (_Product.NewOrUsed == New)
            {
                RunProductNew(_Product);
            }
            else
            {
                RunProductUsed(_Product);
            }
        }

        private void RunProductUsed(clsAllProducts prProduct)
        {

            ctcProdSpecs.Content = new ucUsedProduct(prProduct);
            
            tblNewOrUsed.Text = ("Used");

        }


        private void RunProductNew(clsAllProducts prProduct)
        {

            ctcProdSpecs.Content = new ucNewProduct(prProduct);
            tblNewOrUsed.Text = ("New");

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                base.OnNavigatedTo(e);
                if (e.Parameter != null)
                {
                    string lcProductCode = e.Parameter.ToString();
                    _Product = await ServiceClient.GetSingleProductAsync(lcProductCode);
                    updatePage();
                }
                else // no parameter -> new artist!
                    _Product = new clsAllProducts();
            }
            catch
            {
                tbMessageShow.Text = "Unable to populate page";
            }
        }
        public int RandomNum ()
        {
            Random random = new Random();
            return random.Next(1000);
        
        }
        private void pushData()
        {
            _Order = new clsOrder();
            int lcOrderID = RandomNum();

            _Order.OrderID = lcOrderID.ToString();
            _Order.ProductCode = _Product.ProductCode;
            _Order.ProductName = _Product.ProductName;
            _Order.PriceAtTimeOfOrder = _Product.PricePerItem;
            _Order.Quantity = int.Parse(tbOrderQuantity.Text);
            _Order.TimeOfOrder = DateTime.Now;
            _Order.DeviceTypeName = _Product.DeviceTypeName;
            _Order.CustomerDetails = tbDeliveryAddress.Text;
        }

        //--------------------------------- Processing an Order -------------------------------------

        private async void updateProductStock()
        {
            try
            {
                _ProductCode = _Product.ProductCode;
                _Product = await ServiceClient.GetSingleProductAsync(_ProductCode);
                updatePage();
            }
            catch
            {
                tbMessageShow.Text = "Unable to update product";
            }

        }

        private async void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pushData();
                if (_Order.Quantity > 0 & _Order.CustomerDetails.Length > 5)
                {
                    updateProductStock();
                    if (_Order.Quantity <= _Product.QuantityInStock)
                    {
                        _Product.QuantityInStock = (_Product.QuantityInStock - _Order.Quantity);
                        await ServiceClient.UpdateProductAsync(_Product);
                        try
                        {
                            tbMessageShow.Text = (await ServiceClient.InsertOrderAsync(_Order));
                        }
                        catch
                        {
                            _Product.QuantityInStock = (_Product.QuantityInStock + _Order.Quantity);
                            await ServiceClient.UpdateProductAsync(_Product);
                        }
                    }
                    else
                    {
                        tbMessageShow.Text = "Please Make sure Order quantity is less than or equal to stock remaining";
                    }
                }
                else
                {
                    tbMessageShow.Text = "Order Quantity must be Greater than one & an address must be entered";
                }
            }
            catch
            {
                tbMessageShow.Text = ("Unable to order, please ensure order quantity is not above stock level");
                updateProductStock();
            }
        }

        //------------------------END Processing Order -------------------------------------------------------

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
