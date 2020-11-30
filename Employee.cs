using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComplete
{
    public class Employee
    {
        private string EmpID;
        private string name;
        private int age;

        //constructor w/out parameters
        public Employee() { }

        //constructor w/ parameters
        public Employee(string EmpID, string name, int age)
        {
            this.EmpID = EmpID;
            this.name = name;
            this.age = age;
        }

        //properties
        public string EmpID1 { get => EmpID; set => EmpID = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //ToString
        public override string ToString()
        {
            return "\nEmployee ID:" + this.EmpID1 +
                "\nName:" + this.Name +
                "\nAge:" + this.Age +
                "\nSalary:" + this.ComputeSalary();

        }

        //Salary
        public double ComputeSalary()
        {
           
            return 0.0;
        }
    }
}
}
