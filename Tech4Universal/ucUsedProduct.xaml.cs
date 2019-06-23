using Windows.UI.Xaml.Controls;


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Tech4Universal
{
    public sealed partial class ucUsedProduct : UserControl, IProductControl
    {
        public ucUsedProduct(clsAllProducts prPoduct)
        {
            this.InitializeComponent();
            UpdateControl(prPoduct);
            
        }

        public void PushData(clsAllProducts prProduct)
        {
            prProduct.ItemCondition = tbCondition.Text;
        }

        public void UpdateControl(clsAllProducts prProduct)
        {
            tbCondition.Text = prProduct.ItemCondition;
        }
    }
}
