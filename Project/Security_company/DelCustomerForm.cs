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
    public partial class DelCustomerForm : Form {
        public DataSet Dataset;
        private int index;

        public DelCustomerForm() {
            InitializeComponent();
        }

        public DelCustomerForm(DataSet dataset) {
            InitializeComponent();
            this.Dataset = dataset;
        }

        private void DelCustomerForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.databaseDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e) {
            
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Verify", MessageBoxButtons.OKCancel) ==
                System.Windows.Forms.DialogResult.OK) {
                    Dataset.Tables["Customer"].Rows[index].Delete();    
                    this.Close();
            }
            else {
                return;
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            index = comboBox1.SelectedIndex;
        }
    }
}
