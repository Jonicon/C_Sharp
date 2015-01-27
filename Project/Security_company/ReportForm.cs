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
    public partial class ReportForm : Form {
        public DataSet DataSet;
        
        public ReportForm() {
            InitializeComponent();
        }

        public ReportForm(DataSet dataset) {
            InitializeComponent();
            this.DataSet = dataset;
            this.FillData();
        }

        private void FillData() {
            int days = getTimeSpan().Days;
            if (days == 0)
                days = 1;

            textBox_RepCustomers.Text   = DataSet.Tables["Customer"].Rows.Count.ToString();
            textBox_RepOfficers.Text    = DataSet.Tables["Officers"].Rows.Count.ToString();
            textBox_RepTargets.Text     = DataSet.Tables["Target"].Rows.Count.ToString();
            textBox_RepVehicles.Text    = DataSet.Tables["Vehicle"].Rows.Count.ToString();
            textBox_RepTagsPerDay.Text  = (DataSet.Tables["TagLog"].Rows.Count / days).ToString();
        }

        private TimeSpan getTimeSpan() {
            TimeSpan ts;
            DateTime first  = (DateTime)DataSet.Tables["TagLog"].Rows[0]["Date"];
            DateTime last   = (DateTime)DataSet.Tables["TagLog"].Rows[DataSet.Tables["TagLog"].Rows.Count - 1]["Date"];
            ts = last - first;

            return ts;
        }
    }
}
