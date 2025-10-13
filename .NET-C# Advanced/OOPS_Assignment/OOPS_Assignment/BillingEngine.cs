using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class BillingEngine(IBillingRule rule)
    {
        public IBillingRule Rule { get; set; }=rule;


        public double GenerateBill(int units)
        {
            return Rule.Compute(units);
        }

    }
}
