using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tech4Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        //populates list of device types
        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstbxDeviceTypes.ItemsSource = await ServiceClient.GetDeviceTypesNamesAsync();
            }
            catch
            {
                tbMessages.Text = ("Error Loading Device Types");
            }
        }
        //opens the product list page
        private void EditDeviceType()
        {
            if (lstbxDeviceTypes.SelectedItem != null)
                Frame.Navigate(typeof(ProductList), lstbxDeviceTypes.SelectedItem);
        }
        //calls to open the product list page
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            EditDeviceType();
        }
        //calls to open the product list page
        private void LstbxDeviceTypes_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            EditDeviceType();
        }
        //exits the application
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
