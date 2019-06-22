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
    public partial class frmOrders : Form
    {
        private static Dictionary<string, frmOrders> _OrdersFormList = new Dictionary<string, frmOrders>();

       // private clsOrderList _Orders;
        private List<clsOrder> _Orders;

        //private frmEditProd EditProd;
        private frmOrders()
        {
            InitializeComponent();
        }

        public static void Run()
        {

            //frmOrders lcOrdersForm;
            //if (string.IsNullOrEmpty(prOrder) ||
            //!_OrdersFormList.TryGetValue(prOrder, out lcOrdersForm))
            //{
            //    lcOrdersForm = new frmOrders();
            //    if (string.IsNullOrEmpty(prOrder))
            //        lcOrdersForm.SetDetails(new clsOrderList());
            //    else
            //    {
            //        _OrdersFormList.Add(prOrder, lcOrdersForm);
            //        lcOrdersForm.refreshFormFromDB(prOrder);
            //    }
            //}
            //else
            //{
            //    lcOrdersForm.Show();
            //    lcOrdersForm.Activate();
            //}
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

//        private void SetDetails(clsOrderList prOrder)
        private void SetDetails(List<clsOrder> prOrder)
        {
            _Orders = prOrder;
            //updateForm();
            UpdateDisplay();
            Show();
            frmHome.Instance.updateDisplay();
            //txtName.Enabled = string.IsNullOrEmpty(_DeviceType.Name);
        }

        //private void UpdateDisplay()
        //{
        //    lstOrders.DataSource = null;
        //    if (_Orders.OrderList != null)
        //        lstOrders.DataSource = _Orders.OrderList;
        //}
        private void UpdateDisplay()
        {
            lstOrders.DataSource = null;
            if (_Orders != null)
                lstOrders.DataSource = _Orders;

            lblTotVal.Text = OrderTotal();

        }

        private string OrderTotal()
        {
            decimal TotalValue = 0;

            foreach (clsOrder c in _Orders)
            {


                TotalValue += c.PriceAtTimeOfOrder * c.Quantity;
         
            }
             return("Total order value =" + TotalValue.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmOrdersView.DispatchOrderForm(lstOrders.SelectedValue as clsOrder);
            UpdateDisplay();
        }

        private void frmMobileDevices_Load(object sender, EventArgs e)
        {

        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
