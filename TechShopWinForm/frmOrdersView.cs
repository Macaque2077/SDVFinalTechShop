using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static void Run(clsOrder prOrder)
        {
            Instance.setDetails(prOrder);
        }

        internal static void DispatchOrderForm(clsOrder prOrder)
        {
            frmOrdersView lcOrdersViewForm;
            lcOrdersViewForm = new frmOrdersView();
            frmOrdersView.Run(prOrder);
            //lcOrdersViewForm.refreshFormFromDB(prOrder);
            
            //lcOrdersViewForm.Show();
            //lcOrdersViewForm.Activate();
        }

        private void setDetails(clsOrder prOrder)
        {
            _Orders = prOrder;
            updateForm();
            ShowDialog();
        }

        //private async void refreshFormFromDB(clsOrder prOrder)
        //{
        //    SetDetails(await ServiceClient.GetOrderDetailsAsync(prOrder));
        //}

        protected virtual void updateForm()
        {
            //tbProductName.Enabled = string.IsNullOrEmpty(_Orders.ProductName);
            tbOrderID.Text = _Orders.OrderID;
            tbProductName.Text = _Orders.ProductName;
            tbProductCode.Text = _Orders.ProductCode;
            tbPriceAtTimeOfOrder.Text = _Orders.PriceAtTimeOfOrder.ToString();
            tbQuantity.Text = _Orders.Quantity.ToString();
            tbTimeOfOrder.Text = _Orders.TimeOfOrder.ToShortDateString();
            tbCustomerDetails.Text = _Orders.CustomerDetails;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
