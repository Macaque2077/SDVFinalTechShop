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

        private void EditDeviceType()
        {
            if (lstbxDeviceTypes.SelectedItem != null)
                Frame.Navigate(typeof(ProductList), lstbxDeviceTypes.SelectedItem);
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            EditDeviceType();
        }

        private void LstbxDeviceTypes_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            EditDeviceType();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
