using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public sealed partial class frmOrders : Form
    {
        public static frmOrders Instance { get { return frmOrders.instance; } } // this is the public property

        private static readonly frmOrders instance = new frmOrders();

        private static Dictionary<string, frmOrders> _OrdersFormList = new Dictionary<string, frmOrders>();

       // private clsOrderList _Orders;
        private List<clsOrder> _Orders;

        //private frmEditProd EditProd;
        private frmOrders()
        {
            InitializeComponent();
        }

        //populates orders screen and calles the function to refresh the form from the DB
        public static void Run()
        {

            frmOrders lcOrdersForm;
            lcOrdersForm = new frmOrders();
            lcOrdersForm.refreshFormFromDB();
            lcOrdersForm.Show();
            lcOrdersForm.Activate();


        }

        //Changed prOrder to object from string as Run sends string and delete sends _Order
        private async void refreshFormFromDB()
        {
            SetDetails(await ServiceClient.GetOrdersAsync());
        }
        //displays the form
        private void SetDetails(List<clsOrder> prOrder)
        {
            _Orders = prOrder;
            UpdateDisplay();
            Show();
            frmHome.Instance.updateDisplay();

        }

        //updates the display
        private void UpdateDisplay()
        {
            lstOrders.DataSource = null;
            if (_Orders != null)
                lstOrders.DataSource = _Orders;

            lblTotVal.Text = OrderTotal();

        }

        //calculates total for orders
        private string OrderTotal()
        {
            decimal TotalValue = 0;

            foreach (clsOrder c in _Orders)
            {


                TotalValue += c.PriceAtTimeOfOrder * c.Quantity;
         
            }
             return("Total order value =" + TotalValue.ToString());
        }

        //Opens the order viewer
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmOrdersView.DispatchOrderForm(lstOrders.SelectedValue as clsOrder);
            UpdateDisplay();
        }

        //deletes the order
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstOrders.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteOrderAsync(lstOrders.SelectedItem as clsOrder));
                refreshFormFromDB();
                //Instead of calling refreshFormFromDB we call set details instead
                SetDetails(await ServiceClient.GetOrdersAsync());
                frmHome.Instance.updateDisplay();
            }
        }
        //hides the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
