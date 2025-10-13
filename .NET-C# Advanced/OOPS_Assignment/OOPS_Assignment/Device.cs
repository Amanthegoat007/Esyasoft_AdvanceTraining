using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class Device
    {
        public string Id;
        public DateTime InstalledOn;
        protected virtual void Describe()
        {
            Console.WriteLine($"Device Id:{Id} | InstalledOn:{InstalledOn}");
        }
    }
}
