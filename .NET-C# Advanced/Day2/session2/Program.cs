using System.Reflection;
using System.Xml.Linq;

namespace session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //calling Human Class object
            Human hey = new(22, "Neymar");
            //hey.Eat();
            hey.Eat();
            Employee e1 = new Employee(1, "aman", 100000);
            Console.WriteLine(e1.CalculateHRA());
        }
    }
    
}
