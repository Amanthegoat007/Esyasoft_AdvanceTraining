using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class Tariff
    {
        public string Name;
        public double RatePerKwh;
        public double FixedCharge;
        public Tariff(string name)
        {
            RatePerKwh = 6.0;
            FixedCharge = 50;
            Name = name;
            Validate();
        }
        public Tariff(string name, double rate)
        {
            RatePerKwh = rate;
            FixedCharge = 50;
            Name = name;
            Validate();
        }
        private void Validate()
        {
            if (RatePerKwh <= 0)
                throw new ArgumentOutOfRangeException(nameof(RatePerKwh), "Rate per kWh must be greater than zero.");

            if (FixedCharge < 0)
                throw new ArgumentOutOfRangeException(nameof(FixedCharge), "Fixed charge cannot be negative.");
        }

        public Tariff(string name, double rate, double fixedCharge)
        {
            RatePerKwh = rate;
            FixedCharge = fixedCharge;
            Name = name;
            Validate();
        }
        public double ComputeBill(int units)
        {
            Console.WriteLine(units * RatePerKwh + FixedCharge);
            return units * RatePerKwh + FixedCharge;
        }
    }


}
