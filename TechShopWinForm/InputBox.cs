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
    public partial class InputBox : Form
    {
        private string _Answer;

        public string Answer { get => _Answer; }

        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtAnswer.Focus();
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length > 0 && txtAnswer.Text.Length < 2)
            {
                _Answer = txtAnswer.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Text = "Please enter one character into the text box.";
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
