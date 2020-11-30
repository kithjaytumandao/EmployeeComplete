using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComplete
{
    class HourlyEmployee
    {
        private double hoursworked;
        private double rate;

        public HourlyEmployee() { }
        public HourlyEmployee(String empID, String name,int age ,double hoursworked,double rate)
            {

            base.EmpID = empID;
            base.Name = name;
            base.Age = age;
            this.hoursworked = hoursworked;
            this.rate = rate;
            
            }
        public double HoursWorked { get => hoursworked; set => hoursworked = value; }
        public double Rate { get => rate; set => rate = value; }
        public override string ToString()
        {
            return "Employee ID:"+base.EmpID+
                "\nName:"+base.Age+
                "\nHours Worked:"+this.hoursworked+
                "\nSalary:"+this.ComputeSalary();
        }
        public override double ComputeSalary()
        {
            return this.HoursWorked * this.Rate;
        }
    }
   
}
