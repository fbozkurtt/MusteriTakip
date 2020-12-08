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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = DatabaseOperations.GetCustomers().Tables["Customer"];
            customersDataGridView.Columns[0].Width = 30;
            //AddCustomer("furkan bozkurt", "deneme şirketi");
        }

        private void customersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var table = (DataTable)dgv.DataSource;
            var id = table.Rows[0].ItemArray[0];
            var name = table.Rows[0].ItemArray[1];
            var company = table.Rows[0].ItemArray[2];
            var notes = table.Rows[0].ItemArray[3];
            new CustomerForm(new Customer()
            {
                Id = Int32.Parse(id.ToString()),
                Name = name.ToString(),
                Company = company.ToString(),
                Notes = notes.ToString()
            }).Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = DatabaseOperations.GetCustomers().Tables["Customer"];
        }
    }
}
