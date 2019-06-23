using Windows.UI.Xaml.Controls;

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
