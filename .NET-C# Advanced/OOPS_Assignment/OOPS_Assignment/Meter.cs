using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class Meter(string MeterSerial,string Location)
    {
        public string MeterSerial=MeterSerial;
        public string Location=Location;
        public DateTime InstalledOn;
        public int LastReadingKwh;
        public void AddReading(int deltaKwh)
        {
            if (deltaKwh > 0) LastReadingKwh = deltaKwh;
        }
        public string Summary()
        {
            string ans= $"{MeterSerial} Location: {Location} | Reading: {LastReadingKwh}";
            return ans;
        }
    }
}
