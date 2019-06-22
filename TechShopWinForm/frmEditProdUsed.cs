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
    public sealed partial class frmProductUsed : frmProduct
    {
        private static readonly frmProductUsed Instance = new frmProductUsed();
        public frmProductUsed()
        {
            InitializeComponent();
        }

        public static void Run(clsAllProducts prUsedProd)
        {
            Instance.SetDetails(prUsedProd);
        }

        protected override void updateForm()
        {

            base.updateForm();
            try
            {
                tbCondition.Text = _Products.ItemCondition.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("no condition");
            }
            



        }

        protected override void pushData()
        {
            base.pushData();
            _Products.ItemCondition = tbCondition.Text;

        }


    }
}
