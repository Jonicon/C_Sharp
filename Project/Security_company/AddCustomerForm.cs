using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_company {
    public partial class AddCustomerForm : Form {

        public DataSet DataSet;
        public DataRow NewCustomer;

        public AddCustomerForm() {
            InitializeComponent();
        }

        public AddCustomerForm(DataSet dataset, DataRow datarow) {
            InitializeComponent();
            this.DataSet        = dataset;
            this.NewCustomer    = datarow;
        }

        private bool ValidateTextFields() {
            if (textBox_AddCustomerID.Text == "") {
                MessageBox.Show("Customer ID must not be empty!");
                return false;
            }

            if (!textBox_AddCustomerID.Text.All(char.IsDigit)) {
                MessageBox.Show("Customer ID must be a number!");
                return false;
            }

            var searchID = DataSet.Tables["Customer"].Select("CustomerID = " + textBox_AddCustomerID.Text);
            if (searchID.Length != 0) {
                MessageBox.Show("Customer ID already taken!");
                return false;
            }

            if (textBox_AddCustomerName.Text == "") {
                MessageBox.Show("Customer must have a name!");
                return false;
            }

            if (textBox_AddCustomerPhone.Text == "") {
                MessageBox.Show("Customer must have a phone number!");
                return false;
            }
                        
            return true;
        }

        private void button_AddCustomerOK_Click(object sender, EventArgs e) {
            if (ValidateTextFields()) {
                NewCustomer["CustomerID"]   = textBox_AddCustomerID.Text;
                NewCustomer["CustomerName"] = textBox_AddCustomerName.Text;
                NewCustomer["Phone"]        = textBox_AddCustomerPhone.Text;
                DataSet.Tables["Customer"].Rows.Add(NewCustomer);
                this.Close();
            }
            else {
                return;
            }
        }
    }
}
