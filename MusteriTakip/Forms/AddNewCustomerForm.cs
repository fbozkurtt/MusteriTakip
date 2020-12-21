using MusteriTakip.Models;
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
    public partial class AddNewCustomerForm : Form
    {
        public AddNewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Müşteri ismi boş olmamalıdır", "Hata!");
            }
            DatabaseOperations.AddCustomer(txtName.Text, txtCompany.Text);
            this.Close();
        }
    }
}
