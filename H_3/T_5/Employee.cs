using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_5
{
    class Employee
    {
        private string name;
        private int id;
        private double salary;

        private string infoConcat;

        public Employee(string nimi, int id, double salary) {
            this.name = nimi;
            this.id = id;
            this.salary = salary;

            this.infoConcat = name + ", " + id.ToString() + ", " + salary.ToString();
        }

        public string Name {
            get{ return name; }
            set { name = value;  }
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }

        public double Salary {
            get { return salary; }
            set { salary = value; }
        }

        public string InfoConcat {
            get { return infoConcat; }
            set {  }
        }
    }
}
