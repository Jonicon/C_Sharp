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
    public partial class AddTargetForm : Form {

        public DataRow NewTarget;
        public DataRow[] SelectedCustomer;
        public DataSet DataSet;

        public AddTargetForm() {
            InitializeComponent();
        }

        public AddTargetForm(DataRow newTarget, DataSet dataset) {
            InitializeComponent();
            this.DataSet = dataset;
            this.NewTarget = newTarget;

            this.comboBox_AddTargetCustomer.DataSource = dataset.Tables["Customer"];
            this.comboBox_AddTargetCustomer.DisplayMember = "CustomerName";

            this.comboBox_AddTargetOfficer.DataSource = dataset.Tables["Officers"];
            this.comboBox_AddTargetOfficer.DisplayMember = "OfficerID";
        }

        private bool ValidateTextFields() {
            // int i;
            SelectedCustomer = DataSet.Tables["Customer"].Select("[CustomerName] = '" + comboBox_AddTargetCustomer.Text + "'");
            if ( textBox_AddTargetID.Text == "" && textBox_AddTargetID.Text.All(char.IsDigit) ) {
                MessageBox.Show("Target ID is either empty or not a number");
                return false;
            }

            var searchID = DataSet.Tables["Target"].Select("TargetID = " + textBox_AddTargetID.Text);
            if (searchID.Length != 0) {
                MessageBox.Show("ID already taken1");
                textBox_AddTargetID.Text = "";
                return false;
            }

            if (textBox_AddTargetAddress.Text == "" ) {
                MessageBox.Show("Must have an address");
                return false;
            }

            if (textBox_AddTargetPhone.Text == "") {
                MessageBox.Show("Must have a phone number!");
                return false;
            }

            if (textBox_AddTargetCheckbefore.Text == "") {
                MessageBox.Show("Check before must not be empty!");
                return false;
            }
                
            return true;
        }

        private void GenerateNTags () {
            //TODO:  generate n tags for a new Target. TagID is autoIncrement,targetID is known, and descrpition???
            int tagCount;
            Int32.TryParse(textBox_NofTags.Text, out tagCount);
            
            if (tagCount >= 0) {
                for (int i = 0; i < tagCount; i++) {
                    DataRow NewTag = DataSet.Tables["Tag"].NewRow();
                    NewTag["TargetID"] = textBox_AddTargetID.Text;
                    NewTag["Description"] = textBox_AddTargetAddress.Text;
                    DataSet.Tables["Tag"].Rows.Add(NewTag);
                }
            }   
        }

        private void button_AddTargetOK_Click(object sender, EventArgs e) {
            
            if (this.ValidateTextFields()) {
                NewTarget["TargetID"]       = textBox_AddTargetID.Text;
                NewTarget["TargetAddress"]  = textBox_AddTargetAddress.Text;
                NewTarget["Phone"]          = textBox_AddTargetPhone.Text;
                NewTarget["CheckBefore"]    = textBox_AddTargetCheckbefore.Text;
                NewTarget["CustomerID"]     = SelectedCustomer[0].ItemArray[0];
                NewTarget["OfficerID"]      = comboBox_AddTargetOfficer.Text;
                DataSet.Tables["Target"].Rows.Add(NewTarget);
                GenerateNTags();
                this.Close();
            }
            else {
                return;
            }
        }
    }
}
