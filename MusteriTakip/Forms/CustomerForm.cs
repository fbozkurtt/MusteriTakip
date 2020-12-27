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
    public partial class CustomerForm : Form
    {
        private MainForm MainForm { get; set; }
        private Customer Customer { get; set; }
        public CustomerForm(Customer customer, Form callingForm)
        {
            this.Customer = customer;
            MainForm = callingForm as MainForm;
            this.DesktopLocation = MainForm.DesktopLocation;
            InitializeComponent();
            //MainForm.Hide();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadOperationsData();
            this.Text = Customer.Name;
            txtName.Text = Customer.Name;
            txtCompany.Text = Customer.Company;
            txtNotes.Text = Customer.Notes;
            lblDateCreated.Text += Customer.DateCreated;
        }
        public void LoadOperationsData()
        {
            operationsDataGridView.DataSource = DatabaseOperations.GetAllOperationsOfCustomer(Customer.Id).Tables["Operation"];
            operationsDataGridView.Columns[0].Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseOperations.UpdateCustomerName(Customer.Id, txtName.Text);
            DatabaseOperations.UpdateCustomerCompany(Customer.Id, txtCompany.Text);
            DatabaseOperations.UpdateCustomerNotes(Customer.Id, txtNotes.Text);
            MainForm.BtnRefreshPerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DatabaseOperations.DeleteCustomer(Customer.Id);
                MainForm.BtnRefreshPerformClick();
                this.Close();
            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            var addNewOperationForm = new AddNewOperationForm(Customer.Id, this);
            addNewOperationForm.Show();
        }

        private void btnDeleteOperation_Click(object sender, EventArgs e)
        {
            try
            {
                var rowToDelete = operationsDataGridView.CurrentRow;
                var id = Convert.ToInt32(rowToDelete.Cells[0].Value);
                var result = MessageBox.Show("Seçili işi silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                DatabaseOperations.DeleteOperation(id);
                operationsDataGridView.Rows.Remove(rowToDelete);
            }
            catch
            {
                MessageBox.Show("Bir iş seçin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //MainForm.Show();
        }

        private void CustomerForm_Move(object sender, EventArgs e)
        {
            MainForm.DesktopLocation = this.DesktopLocation;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void operationsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var currentRow = dgv.CurrentRow;
            MessageBox.Show(currentRow.Cells[1].Value.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
