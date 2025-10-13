using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    Task 4:Employee Salary Management
//    Create a class Employee with fields: id, name, basicSalary, hra, da, grossSalary.
//    Implement:
//Constructor to initialize id, name, basicSalary.

//Method to calculate hra = 10 % of basicSalary, da = 5% of basicSalary, grossSalary = basic + hra + da.
//Create objects and display detailed salary slips.
namespace session2
{
    internal class Employee(int id, string name, int basic)
    {
        public int id = id;
        public string name = name;
        public int basicSalary = basic;
        public double hra;
        public double da;
        public double grossSalary;
        public double CalculateHRA()
        {
            hra = 0.1 * basicSalary;
            return hra;
        }
        public double CalculateDA()
        {
            da = 0.05 * basicSalary;
            return da;
        }
        public double CalculateGrossSalary()
        {
            grossSalary = basic + hra + da;
            return grossSalary;
        }
    }
}
