using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComplete
{
    class ComEmployee
    {
        private double sales;
        private double percentage;
        public ComEmployee(){}
        public ComEmployee(String empID, String name, int age, double sales, double percentage)
        {
            base.EmpId = empID;
            base.Name = name;
            base.Age = age;
            this.sales = sales;
            this.percentage = percentage;
        }
        public double Sales { get => sales; set => percentage = value; }
        public double Percentage { get => percentage; set => percentage = value; }
        public override string ToString()
        {
            return "\nEmployee ID:" + base.EmpID +
                "\nName:" + base.Name +
                "\nAge:" + base.Age +
                "\nSales" + this.sales +
                "\nPercentage:" + this.percentage +
                "\nSalary:" +this.ComputeSalary();

        }
        public override double ComputeSalary()
        {
            return this.Sales * this.Percentage;
         }
    }
}
