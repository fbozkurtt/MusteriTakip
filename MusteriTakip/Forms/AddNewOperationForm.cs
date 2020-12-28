using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip.Forms
{
    public partial class AddNewOperationForm : Form
    {
        private CustomerForm CustomerForm { get; set; }
        private int CustomerId { get; set; }
        public AddNewOperationForm(int customerId, Form callingForm)
        {
            CustomerForm = callingForm as CustomerForm;
            CustomerId = customerId;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Açıklama boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DatabaseOperations.AddOperation(txtDescription.Text, CustomerId, Convert.ToDouble(txtChargeAmount.Text));
                CustomerForm.LoadOperationsData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtChargeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
