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

        public Employee(string nimi) {
            this.name = nimi;
        }

        public string Name
        {
            get{
                return name;
            }
            set{
                name = value;
            }
        }


    }
}
