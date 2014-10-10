using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_5
{
    public partial class Form1 : Form
    {

        ArrayList empolyees;
        ArrayList chosenEmployees;

        public Form1()
        {
            InitializeComponent();
        }

        private void init_Employees()
        {  
            empolyees =         new ArrayList();
            chosenEmployees =   new ArrayList();

            empolyees.Add(new Employee("Jussi", 001, 1200));
            empolyees.Add(new Employee("Taija", 002, 1200));
            empolyees.Add(new Employee("Jaana", 003, 1200));
            empolyees.Add(new Employee("Tauno", 004, 1200));
        }

        private bool verifyEmpolyeeName( string name ) {
            foreach (Employee n in empolyees) {
                if (name == n.Name ) {
                    return false;
                }
            } 
            return true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
                chosenEmployees.Add( EmployeesComboBox.SelectedItem );
                ChosenEmployeesCheckBox.DataSource = null;
                ChosenEmployeesCheckBox.DataSource = chosenEmployees;
                ChosenEmployeesCheckBox.DisplayMember = "InfoConcat";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_Employees();

            EmployeesComboBox.DataSource = empolyees;
            EmployeesComboBox.DisplayMember = "name";
            // EmployeesComboBox.Clear();

            ChosenEmployeesCheckBox.DataSource = chosenEmployees;
            ChosenEmployeesCheckBox.DisplayMember = "name";
            ChosenEmployeesCheckBox.ClearSelected();

            employeesLength.Text = empolyees.Count.ToString();
        }

        private void NewEmployeeFlagLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            char[] separator = new char[] { ',' };
            string[] attributes = NewEmployeeTextBox1.Text.Split(separator);
            Employee emp;


            if (String.IsNullOrEmpty( NewEmployeeTextBox1.Text ) )
            {
                NewEmployeeFlagLabel.Text = "Tekstikenttä on tyhjä!";
                NewEmployeeFlagLabel.Show();
            }
            else if ( !verifyEmpolyeeName(attributes[0]) )
            {
                NewEmployeeFlagLabel.Text = "Nimi on jo listassa!";
                NewEmployeeFlagLabel.Show();
            }
            else
            {

                emp = new Employee(Convert.ToString(attributes[0]),
                                    Convert.ToInt16(attributes[1]),
                                    Convert.ToDouble(attributes[2]));

                empolyees.Add(emp);
                employeesLength.Text = empolyees.Count.ToString();
                NewEmployeeTextBox1.Text = "";
                NewEmployeeFlagLabel.Hide();
                EmployeesComboBox.DataSource = null;
                EmployeesComboBox.DataSource = empolyees;
                EmployeesComboBox.DisplayMember = "name";
                emp = null;
            }
        }

        private void ChosenEmployeesCheckBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            Employee temp;
            if (chosenEmployees.Count != 0 && e.CurrentValue == CheckState.Unchecked && e.Index != 0) {
                temp = (Employee)chosenEmployees[e.Index-1];
                chosenEmployees[e.Index-1] = chosenEmployees[e.Index];
                chosenEmployees[e.Index] = temp;


                //ChosenEmployeesCheckBox.ClearSelected();
                e.NewValue = CheckState.Unchecked;
               

                ChosenEmployeesCheckBox.DataSource = null;
                ChosenEmployeesCheckBox.DataSource = chosenEmployees;
                ChosenEmployeesCheckBox.DisplayMember = "name";
            }
        }
    }
}
