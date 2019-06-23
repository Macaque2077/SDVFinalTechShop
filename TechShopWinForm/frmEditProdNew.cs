using System;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public sealed partial class frmProductNew : frmProduct
    {
        private static readonly frmProductNew Instance = new frmProductNew();
        public frmProductNew()
        {
            InitializeComponent();
        }

        public static void Run(clsAllProducts prNewProd)
        {
            Instance.SetDetails(prNewProd);
        }

        protected override void updateForm()
        {
            base.updateForm();
            tbWarranty.Text = _Products.Warranty.ToString();
            
        }

        protected override void pushData()
        {
            base.pushData();
            try
            {
                _Products.Warranty = int.Parse(tbWarranty.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect value entered " +
                   " warranty should be a number");
            }

        }

    }
}
