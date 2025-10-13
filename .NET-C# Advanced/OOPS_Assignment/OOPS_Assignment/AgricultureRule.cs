using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class AgricultureRule : IBillingRule
    {
        public double Compute(int units)
    {
            return 3.0 / units;
    }
}
}
