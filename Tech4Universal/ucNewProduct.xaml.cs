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


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Tech4Universal
{
    public sealed partial class ucNewProduct : UserControl, IProductControl
    {
        public ucNewProduct(clsAllProducts prProduct)
        {
            this.InitializeComponent();
            UpdateControl(prProduct);
        }

        public void PushData(clsAllProducts prProduct)
        {
            prProduct.Warranty = int.Parse(tbWarranty.Text);
        }

        public void UpdateControl(clsAllProducts prProduct)
        {
            tbWarranty.Text = prProduct.Warranty.ToString();
        }
    }
}
