using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComplete
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee("001", "Erap Estrada", 34);
            Console.WriteLine(emp);

            HourlyEmployee hrly = new HourlyEmployee("002", "Erap Estrada", 54, 10000,333.00);
            ComEmployee com = new ComEmployee("003", 54, 10000000, .10);


            ComEmployee com1 = new ComEmployee();
            Console.Write("\nEnter ID Number:");
            com1.EmpID = Console.ReadLine();
            Console.Write("\nEnter Name:");
            com1.Name = Console.ReadLine();
            Console.Write("\nEnter Age:");
            com1.Age = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Sales:");
            com1.Sales = double.Parse(Console.ReadLine());
            Console.Write("\nEnter Percentage(in decimal):");
            com1.Percentage = double.Parse(Console.ReadLine());

            Console.WriteLine("Employee ID:"+com1.EmpID);
            Console.WriteLine("Name:"+com1.Name);
            Console.WriteLine("Age:"+com1.Age);
            Console.WriteLine("Sales:(0:c2)",com1.Sales);
            Console.WriteLine("Percentage:(0:c2)",com1.Percentage);
            Console.WriteLine("Salary:(0:c2)",com1.ComputeSalary());
        }
    }
}
