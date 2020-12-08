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
        public Customer Customer { get; set; }
        public List<Operation> Operations { get; set; }
        public string Company { get; set; }
        public CustomerForm(Customer customer)
        {
            this.Customer = customer;
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.Text = Customer.Name + " / " + Customer.Company;
            txtName.Text = Customer.Name;
            txtCompany.Text = Customer.Company;
            txtNotes.Text = Customer.Notes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseOperations.UpdateCustomerNotes(Customer.Id, txtNotes.Text);
            MessageBox.Show("Değişikler kaydedildi", "Bilgi");
        }
    }
}
