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
    public partial class Form2Simulation : Form {
        public Form2Simulation() {
            InitializeComponent();
        }

        private void Form2Simulation_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.TagLog' table. You can move, or remove it, as needed.
            this.tagLogTableAdapter.Fill(this.databaseDataSet.TagLog);
            // TODO: This line of code loads data into the 'databaseDataSet.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this.databaseDataSet.Tag);

        }

        private void button1_Click(object sender, EventArgs e) {
            if ( ValidateTagSim(Convert.ToInt32(tb_tagsimOfficerID.Text)) ) {
                int tagid = (int)lb_tagsimList.SelectedValue;
                DateTime dt = DateTime.Now;
                DataRow[] gettargetid = databaseDataSet.Tag.Select("TagID = " + tagid.ToString());
                int targetid = Convert.ToInt32( gettargetid[0].ItemArray[1] );
                int officerid = Convert.ToInt32(tb_tagsimOfficerID.Text);

                DataRow newtaglogrow = databaseDataSet.Tables["TagLog"].NewRow();
                newtaglogrow["TagID"]       = tagid;
                newtaglogrow["Date"]        = dt;
                newtaglogrow["TargetID"]    = targetid;
                newtaglogrow["OfficerID"]   = officerid;

                MessageBox.Show(tb_tagsimOfficerID.Text, officerid.ToString(), MessageBoxButtons.OK , MessageBoxIcon.Error);

                databaseDataSet.Tables["TagLog"].Rows.Add(newtaglogrow);
                tagLogTableAdapter.Update(databaseDataSet.TagLog);
                tb_tagsimOfficerID.Text = "";
            }
        }

        private bool ValidateTagSim(int i) {
            // int n = 0;
            string s = "OfficerID = " + i.ToString();
            DataRow[] result = databaseDataSet.Officers.Select(s);

            if (result != null) {
                return true;
            }
            else {
                MessageBox.Show("Invalid officer ID", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
