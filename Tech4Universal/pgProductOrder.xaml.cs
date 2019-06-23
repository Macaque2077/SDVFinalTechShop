using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace Tech4Universal
{
    /// <summary>
    /// The Order page, here customers can order a product
    /// </summary>
    public sealed partial class pgProduct : Page
    {
        private clsAllProducts _Product;

        private clsOrder _Order;

        private string _ProductCode;
        public pgProduct()
        {
            this.InitializeComponent();
        }

        //populates text boxes with the product details
        private void updatePage()
        {
            tblProductTitle.Text = (_Product.ProductName);
            tbProductCode.Text = (_Product.ProductCode);
            tbBrand.Text = (_Product.Brand);
            tbPrice.Text = (_Product.PricePerItem.ToString());
            tbStock.Text = (_Product.QuantityInStock.ToString());

            tbDescription.Text = (_Product.ItemDescription);
            RunNeworUsed();
        }

        //handles displaying a new or used product
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

        //opens page for a used product
        private void RunProductUsed(clsAllProducts prProduct)
        {

            ctcProdSpecs.Content = new ucUsedProduct(prProduct);
            
            tblNewOrUsed.Text = ("Used");

        }

        //opens page for a new product
        private void RunProductNew(clsAllProducts prProduct)
        {

            ctcProdSpecs.Content = new ucNewProduct(prProduct);
            tblNewOrUsed.Text = ("New");

        }

        //retrieves product details from the DB
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
        
        //creates a random number for the order ID
        public int RandomNum ()
        {
            Random random = new Random();
            return random.Next(1000000);
        
        }

        //Creates order
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
        //updates the page to make sure stock has not changes
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

        //handles the order, calls the updater and validOrder() to avoid order amount exceeding stock available and sends order to the DB
        private async void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pushData();
                updateProductStock();
                if (validOrder() == true)
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
                    tbMessageShow.Text = "invalid order quantity or no address has been entered";
                }
            }
            catch
            {
                tbMessageShow.Text = ("Unable to order, please ensure order quantity is not above stock level");
                updateProductStock();
            }
        }

        //checks valid inputs have been made for the order
        private bool validOrder()
        {
            if (_Order.Quantity > 0 && _Order.CustomerDetails.Length > 5 && _Order.Quantity <= _Product.QuantityInStock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //------------------------END Processing Order -------------------------------------------------------

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
