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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Object o in EmployeesListBox.SelectedItems)
            {
                chosenEmployees.Add(o);
                ChosenEmployeesListBox.DataSource = null; 
                ChosenEmployeesListBox.DataSource = chosenEmployees;
                ChosenEmployeesListBox.DisplayMember = "InfoConcat";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_Employees();

            EmployeesListBox.DataSource = empolyees;
            EmployeesListBox.DisplayMember = "name";
            EmployeesListBox.ClearSelected();

            ChosenEmployeesListBox.DataSource = chosenEmployees;
            ChosenEmployeesListBox.DisplayMember = "name";
            ChosenEmployeesListBox.ClearSelected();
        }

        private void NewEmployeeFlagLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            char[] separator = new char[] { ',' };
            string[] attributes = NewEmployeeTextBox1.Text.Split(separator);

            Employee emp = new Employee( attributes[0],
                Convert.ToInt16(attributes[1]),
                Convert.ToDouble(attributes[2]) );

            if (String.IsNullOrEmpty( emp.Name ) )
            {
                NewEmployeeFlagLabel.Text = "Tekstikenttä on tyhjä!";
                NewEmployeeFlagLabel.Show();
            }
            else if (empolyees.Contains(emp.Name))
            {
                NewEmployeeFlagLabel.Text = "Nimi on jo listassa!";
                NewEmployeeFlagLabel.Show();
            }
            else
            {
                empolyees.Add(emp);
                EmployeesListBox.DataSource = null;
                EmployeesListBox.DataSource = empolyees;
                EmployeesListBox.DisplayMember = "name";
            }
        }
    }
}
