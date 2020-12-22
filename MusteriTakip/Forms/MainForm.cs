using MusteriTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip.Forms
{
    public partial class MainForm : Form
    {
        public void BtnRefreshPerformClick()
        {
            btnRefresh.PerformClick();
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = DatabaseOperations.GetAllCustomers().Tables["Customer"];
            customersDataGridView.Columns[0].Visible = false;
        }

        private void customersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var currentRow = dgv.CurrentRow;
            Int32.TryParse(currentRow.Cells[0].Value.ToString(), out var id);
            new CustomerForm(DatabaseOperations.GetCustomerById(id), this).Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            customersDataGridView.DataSource = DatabaseOperations.GetAllCustomers().Tables["Customer"];
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addnewCustomerForm = new AddNewCustomerForm(this);
            addnewCustomerForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                customersDataGridView.DataSource = DatabaseOperations.GetAllCustomers().Tables["Customer"];
            }
            else
            {
                customersDataGridView.DataSource = DatabaseOperations.GetCustomersByName(txtSearch.Text).Tables["Customer"];
            }
        }
    }
}
