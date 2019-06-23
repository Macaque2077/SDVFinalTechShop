using System;
using System.Windows.Forms;

namespace TechShopWinForm
{
    public partial class InputBox : Form
    {
        private string _Answer;

        public string Answer { get => _Answer; }

        //populates the form
        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtAnswer.Focus();
            ShowDialog();
        }
        //closes the form
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        //checks whether the user has enter a single character
        private void btnOK_Click(object sender, EventArgs e)
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
    }
}
