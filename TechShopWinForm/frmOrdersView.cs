using System;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public partial class frmOrdersView : Form
    {
        private static readonly frmOrdersView Instance = new frmOrdersView();

        private clsOrder _Orders;

        private frmOrdersView()
        {
            InitializeComponent();
        }
        //calls to set the details for the form
        public static void Run(clsOrder prOrder)
        {
            Instance.setDetails(prOrder);
        }

        //creates the new form 
        internal static void DispatchOrderForm(clsOrder prOrder)
        {
            frmOrdersView lcOrdersViewForm;
            lcOrdersViewForm = new frmOrdersView();
            frmOrdersView.Run(prOrder);
        }

        //sets the details for the form
        private void setDetails(clsOrder prOrder)
        {
            _Orders = prOrder;
            updateForm();
            ShowDialog();
        }

        //Updates the text boxes on the form
        protected virtual void updateForm()
        {
            tbOrderID.Text = _Orders.OrderID;
            tbProductName.Text = _Orders.ProductName;
            tbProductCode.Text = _Orders.ProductCode;
            tbPriceAtTimeOfOrder.Text = _Orders.PriceAtTimeOfOrder.ToString();
            tbQuantity.Text = _Orders.Quantity.ToString();
            tbTimeOfOrder.Text = _Orders.TimeOfOrder.ToShortDateString();
            tbCustomerDetails.Text = _Orders.CustomerDetails;
        }

        //closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
