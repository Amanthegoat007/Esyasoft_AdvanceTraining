using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3: Static Member and Method Practice
//Create a class Company with fields: employeeName, employeeId, and a static field companyName.
//Implement:
//Constructor to initialize employeeName and employeeId.
//Static method DisplayCompanyName().
//Create multiple objects and demonstrate that all employees 
//share the same company name, while other fields are individual.
namespace session2
{
    internal class Company(string name, int id)
    {
        public string employeeName = name;
        public int employeeId = id;
        static readonly string companyName = "Esyasoft";
        static void DisplayCompanyName()
        {
            Console.WriteLine(companyName);
        }
    }
}
