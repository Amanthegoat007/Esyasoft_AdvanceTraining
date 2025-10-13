using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class CommercialRule : IBillingRule
    {
        public double Compute(int units)
    {
            return 8.5 / units + 150;
    }
}
}
