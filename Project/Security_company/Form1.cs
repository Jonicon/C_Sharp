using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Security_company {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();           
        }

        private void label1_Click(object sender, EventArgs e) {
                    }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'databaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.databaseDataSet.Vehicle);
            // TODO: This line of code loads data into the 'databaseDataSet.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this.databaseDataSet.Tag);
            // TODO: This line of code loads data into the 'databaseDataSet.TagLog' table. You can move, or remove it, as needed.
            this.tagLogTableAdapter.Fill(this.databaseDataSet.TagLog);
            // TODO: This line of code loads data into the 'databaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.databaseDataSet.Customer);
            // TODO: This line of code loads data into the 'databaseDataSet.Target' table. You can move, or remove it, as needed.
            this.targetTableAdapter.Fill(this.databaseDataSet.Target);
            // TODO: This line of code loads data into the 'databaseDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.databaseDataSet.Officers);

            
        }

        static private string GetConnectionString() {
            // To avoid storing the connection string in your code,  
            // you can retrieve it from a configuration file. 
            return "Data Source=localhost;Initial Catalog=Security_Company;"
                + "Integrated Security=true;";
        }

        private void OfficerList_SelectedIndexChanged(object sender, EventArgs e) {
            // DataRow[] result = DatabaseDataSet.
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //Officer IDfilter
        private void textBox1_TextChanged(object sender, EventArgs e) {
            int i;
            if (textBox1.Text != "" && Int32.TryParse(textBox1.Text, out i)) {
                officersBindingSource.Filter = string.Format("OfficerID = {0}", i);
            }
            else {
                officersBindingSource.Filter = "";
            }
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        //Officer Name filter
        private void textBox2_TextChanged(object sender, EventArgs e) {
            officersBindingSource.Filter = string.Format("OfficerName LIKE '%{0}%'", textBox2.Text);
     
        }

        //Officer Phone filter
        private void textBox3_TextChanged(object sender, EventArgs e) {
            officersBindingSource.Filter = string.Format("Phone LIKE '%{0}%'", textBox3.Text);
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e) {
            try {
                this.targetTableAdapter.FillBy(this.databaseDataSet.Target);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.customerTableAdapter.Fill(this.databaseDataSet.Customer);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e) {
            try {
                this.customerTableAdapter.FillBy(this.databaseDataSet.Customer);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.targetTableAdapter.FillBy1(this.databaseDataSet.Target);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.targetTableAdapter.FillBy2(this.databaseDataSet.Target);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e) {
            try {
                this.targetTableAdapter.FillBy(this.databaseDataSet.Target);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            //target ID
            int i;
            if (textBox4.Text != "" && Int32.TryParse(textBox4.Text, out i)) {
                targetBindingSource.Filter = string.Format("TargetID = {0}", i);
            }
            else {
                targetBindingSource.Filter = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e) {
            //target address
            targetBindingSource.Filter = string.Format("TargetAddress LIKE '%{0}%'", textBox6.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            // customer of target
            int i;
            if (textBox5.Text != "" && Int32.TryParse(textBox5.Text, out i) ){
                targetBindingSource.Filter = string.Format("CustomerID = {0}", i);
            }
            else {
                targetBindingSource.Filter = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e) {
            // phone, target
            targetBindingSource.Filter = string.Format("Phone LIKE '%{0}%'", textBox6.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e) {
            // check time
            targetBindingSource.Filter = string.Format("CheckBefore LIKE '%{0}%'", textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e) {
            // Customer ID
            int i;
            if (textBox9.Text != "" && Int32.TryParse(textBox9.Text, out i)) {
                customerBindingSource.Filter = string.Format("CustomerID = {0}", i);
            }
            else {
                customerBindingSource.Filter = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e) {
            // Customer name
            customerBindingSource.Filter = string.Format("CustomerName LIKE '%{0}%'", textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e) {
            // Customer Phone
            customerBindingSource.Filter = string.Format("Phone LIKE '%{0}%'", textBox11.Text);
        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy1(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy2(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy3(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click_1(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy3(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_2(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy2(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.officersTableAdapter.FillBy4(this.databaseDataSet.Officers);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simulateTaggingToolStripMenuItem_Click(object sender, EventArgs e) {
            Form sim = new Form2Simulation();
            sim.Activate();
            sim.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            databaseDataSet.AcceptChanges();
            Application.Exit();
        }

        private void officerToolStripMenuItem_Click(object sender, EventArgs e) {
            DataRow NewOfficer = databaseDataSet.Tables["Officers"].NewRow();
            new AddOfficerForm(NewOfficer, this.databaseDataSet).ShowDialog(this);
            officersTableAdapter.Update(databaseDataSet.Officers);
        }

        private void targetToolStripMenuItem_Click(object sender, EventArgs e) {
            DataRow NewTarget = databaseDataSet.Tables["Target"].NewRow();
            new AddTargetForm(NewTarget, this.databaseDataSet).ShowDialog(this);
            targetTableAdapter.Update(databaseDataSet.Target);
        }

        private void textBox15_TextChanged(object sender, EventArgs e) {
            int i;
            if (textBox15.Text != "" && Int32.TryParse(textBox15.Text, out i)) {
                targetBindingSource.Filter = string.Format("OfficerID = {0}", i);
            }
            else {
                targetBindingSource.Filter = "";
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e) {
            DataRow NewCustomer = databaseDataSet.Tables["Customer"].NewRow();
            new AddCustomerForm(databaseDataSet, NewCustomer).ShowDialog(this);
            customerTableAdapter.Update(NewCustomer);
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e) {
            DataRow NewVehicle = databaseDataSet.Tables["Vehicle"].NewRow();
            new AddVehicleForm(databaseDataSet, NewVehicle).ShowDialog(this);
            vehicleTableAdapter.Update(databaseDataSet.Vehicle);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            customerTableAdapter.Update(this.databaseDataSet.Customer);
            officersTableAdapter.Update(this.databaseDataSet.Officers);
            tagTableAdapter.Update(this.databaseDataSet.Tag);
            tagLogTableAdapter.Update(this.databaseDataSet.TagLog);
            targetTableAdapter.Update(this.databaseDataSet.Target);
            vehicleTableAdapter.Update(this.databaseDataSet.Vehicle);
            MessageBox.Show("Tables updated succesfully");
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e) {
            new DelCustomerForm(databaseDataSet).ShowDialog(this);
            customerTableAdapter.Update(databaseDataSet.Customer);
        }

        private void officerToolStripMenuItem1_Click(object sender, EventArgs e) {
            new DelOfficerForm(databaseDataSet).ShowDialog(this);
            officersTableAdapter.Update(databaseDataSet.Officers);
        }

        private void targetToolStripMenuItem1_Click(object sender, EventArgs e) {
            new DelTargetForm(databaseDataSet).ShowDialog(this);
            targetTableAdapter.Update(databaseDataSet.Target);
        }

        private void vehicelToolStripMenuItem_Click(object sender, EventArgs e) {
            new DelVehicleForm(databaseDataSet).ShowDialog(this);
            vehicleTableAdapter.Update(databaseDataSet.Vehicle);
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e) {
            new ReportForm(databaseDataSet).ShowDialog(this);
        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e) {
            try {
                this.vehicleTableAdapter.FillBy(this.databaseDataSet.Vehicle);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e) {
            try {
                this.tagTableAdapter.FillBy(this.databaseDataSet.Tag);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
