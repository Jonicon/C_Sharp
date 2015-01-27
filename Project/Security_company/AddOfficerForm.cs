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
    public partial class AddOfficerForm : Form {

        public DataRow NewOfficer;
        public DataSet dataset;

        public AddOfficerForm() {
            InitializeComponent();
        }

        public AddOfficerForm(DataRow newofficer, DatabaseDataSet dataset) {
            InitializeComponent();
            NewOfficer = newofficer;
            this.dataset = dataset;
        }

        private bool ValidateTextFields() {
            // check that ID is numeric and not empty
            if (textBox_AddOfficerId.Text == "" || !textBox_AddOfficerId.Text.All(char.IsDigit)) {
                MessageBox.Show("ID is empty or invalid!");
                return false;
            }

            // search Officers table for ID clashes
            var searchId = dataset.Tables["Officers"].Select("officerID = " + textBox_AddOfficerId.Text);
            if (searchId.Length != 0) {
                MessageBox.Show("ID is already taken", "Error");
                textBox_AddOfficerId.Text = "";
                return false;
            }

            //check Name and Phone not empty
            if (textBox_AddOfficerName.Text == "" || textBox_AddOfficerPhone.Text == "") {
                MessageBox.Show("Name or Phone is empty");
                return false;
            }

            return true;
        }

        private void button_AddOfficer_Click(object sender, EventArgs e) {
            if (ValidateTextFields()) {
                NewOfficer["OfficerID"]     = textBox_AddOfficerId.Text;
                NewOfficer["OfficerName"]   = textBox_AddOfficerName.Text;
                NewOfficer["Phone"]         = textBox_AddOfficerPhone.Text;
                NewOfficer["Active"]        = true;
                dataset.Tables["Officers"].Rows.Add(NewOfficer);
                
                
                this.Close();
            }
            else {
                // MessageBox.Show("One or more of the datafields is invalid", "Invalid data" );
                return;
            }
        }
    }
}
