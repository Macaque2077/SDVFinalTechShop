using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Tech4Universal
{
    /// <summary>
    /// Page that displays the list of product for the device type
    /// </summary>
    public sealed partial class ProductList : Page
    {
        private clsDeviceType _DeviceType;
        public ProductList()
        {
            this.InitializeComponent();
            
        }



        private void UpdateDisplay()
        {
            try
            {
                if (_DeviceType.Name != null)
                {
                    tbDeviceTypeName.Text = _DeviceType.Name;
                }
                
                lstbxProductList.ItemsSource = null;
                if (_DeviceType.ProductsList != null)
                    lstbxProductList.ItemsSource = _DeviceType.ProductsList;
            }
            catch
            {
                txbMessage.Text = "Unable to populate page";
            }

        }
        //retrieves and addes the product list to _DeviceType
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                base.OnNavigatedTo(e);
                if (e.Parameter != null)
                {
                    string lcDeviceTypeName = e.Parameter.ToString();
                    _DeviceType = await ServiceClient.GetDeviceTypeAsync(lcDeviceTypeName);
                    UpdateDisplay();
                }
                else // no parameter -> new artist!
                    _DeviceType = new clsDeviceType();
            }
            catch
            {
                txbMessage.Text = "Unable to populate page";
            }

        }
        //Navigates to the product order page
        private void LstbxProductList_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (lstbxProductList.SelectedItem != null)
                Frame.Navigate(typeof(pgProduct), lstbxProductList.SelectedItem);

        }
        //goes to the Home page
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnSelect_Clicked(object sender, RoutedEventArgs e)
        {
            if (lstbxProductList.SelectedItem != null)
                Frame.Navigate(typeof(pgProduct), lstbxProductList.SelectedItem);
        }
    }
}
