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
    public partial class DelOfficerForm : Form {
        public DataSet DataSet;
        private int index;

        public DelOfficerForm() {
            InitializeComponent();
        }

        public DelOfficerForm(DataSet dataset) {
            InitializeComponent();
            this.DataSet = dataset;
        }

        private void DelOfficerForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.databaseDataSet.Officers);

        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to remove this officer?", "Verify", MessageBoxButtons.OKCancel) ==
                System.Windows.Forms.DialogResult.OK) {
                    DataSet.Tables["Officers"].Rows[index].Delete();
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
