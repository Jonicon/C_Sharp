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

            empolyees.Add("Pekka");
            empolyees.Add("Jaana");
            empolyees.Add("Jussi");
            empolyees.Add("Taija");
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
            string newEmployee = NewEmployeeTextBox1.Text;

            if (!String.IsNullOrEmpty(newEmployee) && !chosenEmployees.Contains(newEmployee) )
            {
                chosenEmployees.Add(newEmployee);
                ChosenEmployeesListBox.DataSource = null; 
                ChosenEmployeesListBox.DataSource = chosenEmployees
            }
        }
    }
}
