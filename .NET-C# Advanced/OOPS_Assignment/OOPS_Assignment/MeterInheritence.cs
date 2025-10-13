using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class MeterInheritence(int pcount): Device
    {
        public int PhaseCount=pcount;
        protected override void Describe()
        {
            Console.WriteLine($"Device Id:{Id} | InstalledOn:{InstalledOn} | PhaseCount:{PhaseCount}");
        }
        
    }
}
