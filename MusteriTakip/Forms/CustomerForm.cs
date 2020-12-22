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
        public CustomerForm(Customer customer, MainForm mainForm)
        {
            this.Customer = customer;
            MainForm = mainForm;
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.Text = Customer.Name + " / " + Customer.Company;
            txtName.Text = Customer.Name;
            txtCompany.Text = Customer.Company;
            txtNotes.Text = Customer.Notes;
            lblDateCreated.Text += Customer.DateCreated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseOperations.UpdateCustomerName(Customer.Id, txtName.Text);
            DatabaseOperations.UpdateCustomerCompany(Customer.Id, txtCompany.Text);
            DatabaseOperations.UpdateCustomerNotes(Customer.Id, txtNotes.Text);
            //MessageBox.Show("Değişikler kaydedildi", "Bilgi");
            MainForm.BtnRefreshPerformClick();
        }
    }
}
