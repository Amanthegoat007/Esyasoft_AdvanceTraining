using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class PhaseCount
        (string ip): Device
    {
        public string IpAddress = ip;
        protected override void Describe()
        {
            Console.WriteLine($"Device Id:{Id} | InstalledOn:{InstalledOn} | IP: {IpAddress}");
        }
        
    }

}
