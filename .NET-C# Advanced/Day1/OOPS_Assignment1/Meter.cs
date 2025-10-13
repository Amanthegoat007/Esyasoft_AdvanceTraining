using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment1
{
    internal class Meter
    {
        public string MeterSerial;
        public string Location;
        public DateTime InstallledOn;
        public int LastReadingKwh;

        public void AddReading(int deltaKwh)
        {
            if(deltaKwh>0) LastReadingKwh = deltaKwh;
            
        }
        public string Summary()
        {
            return $"SERIAL Location: {Location} | Reading: {LastReadingKwh}";
        }
    }

}
