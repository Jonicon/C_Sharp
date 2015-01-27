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
    public partial class AddVehicleForm : Form {

        public DataSet DataSet;
        public DataRow NewVehicle;

        public AddVehicleForm() {
            InitializeComponent();
        }

        public AddVehicleForm(DataSet DataSet, DataRow NewVehicle) {
            InitializeComponent();
            this.DataSet = DataSet;
            this.NewVehicle = NewVehicle;
        }


        // Not needed
        private void AddVehicleForm_Load(object sender, EventArgs e) {

        }

        //Validate text fields
        private bool ValidateTextFields() {
            // TODO: DONE?  
            if (!textBox_AddVehicleID.Text.All(char.IsDigit)) {
                MessageBox.Show("ID must be a number!", "Error");
                return false;
            }

            var searchID = DataSet.Tables["Vehicle"].Select("VehicleID = " + textBox_AddVehicleID.Text);
            if (searchID.Length != 0) {
                MessageBox.Show("Vehicel ID already taken!", "Error");
                return false;
            }

            if (textBox_AddVehiclePlate.Text == "") {
                MessageBox.Show("Must have a plate number!", "Error");
                return false;
            }
            return true;
        }

        private void button_AddVehicleOk_Click(object sender, EventArgs e) {
            //TODO:
            if (ValidateTextFields()) {
                NewVehicle["VehicleID"] = textBox_AddVehicleID.Text;
                NewVehicle["Platenumber"] = textBox_AddVehiclePlate.Text;
                NewVehicle["Desciption"] = textBox_AddVehDesc.Text;
                DataSet.Tables["Vehicle"].Rows.Add(NewVehicle);
                this.Close();
            }
            else {
                return;
            }
        }
    }
}
