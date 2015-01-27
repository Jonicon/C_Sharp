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
    public partial class DelVehicleForm : Form {
        public DataSet DataSet;
        private int index;

        public DelVehicleForm() {
            InitializeComponent();
        }

        public DelVehicleForm(DataSet dataset) {
            InitializeComponent();
            this.DataSet = dataset;
        }

        private void DelVehicleForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.databaseDataSet.Vehicle);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            index = comboBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to remove this Vehicle?", "Verify", MessageBoxButtons.OKCancel) ==
                System.Windows.Forms.DialogResult.OK) {
                    DataSet.Tables["Vehicle"].Rows[index].Delete();
                    this.Close();
            }
            else {
                return;
            }
        }
    }
}
