using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class DomesticRule: IBillingRule
    {
        public double Compute(int units)
        {
            return 6.0 / units + 50;
        }
    }
}
