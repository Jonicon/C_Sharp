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
    public partial class DelTargetForm : Form {
        public DataSet DataSet;
        private int index;
        private int tagID;

        public DelTargetForm() {
            InitializeComponent();
        }

        public DelTargetForm(DataSet dataset) {
            InitializeComponent();
            this.DataSet = dataset;
        }

        private void DelTargetForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.Target' table. You can move, or remove it, as needed.
            this.targetTableAdapter.Fill(this.databaseDataSet.Target);

        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to remove this target", "Verfiy", MessageBoxButtons.OKCancel) ==
                System.Windows.Forms.DialogResult.OK) {
                    DataSet.Tables["Target"].Rows[index].Delete();
                    RemoveChosenTags();
                    this.Close();
            }
            else {
                return;
            }
        }

        private void comboBox_DelTarget_SelectedIndexChanged(object sender, EventArgs e) {
            index = comboBox_DelTarget.SelectedIndex;;
        }

        // Get tags of selected target and remove
        private void RemoveChosenTags() {

            DataRow[] dr = DataSet.Tables["Tag"].Select("TargetID = " + comboBox_DelTarget.SelectedValue);
            for (int i = 0; i != dr.Length; i++) {
                dr[i].Delete();
            }
        }
    }
}
