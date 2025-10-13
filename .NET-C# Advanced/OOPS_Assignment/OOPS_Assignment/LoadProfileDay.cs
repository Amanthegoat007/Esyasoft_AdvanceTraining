using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    public class LoadProfileDay
    {
        public DateTime Date { get; }
        public int[] HourlyKwh { get; } // length 24
        public LoadProfileDay(DateTime date, int[] hourly)
        {
            HourlyKwh = new int[24];
            // clone array; validate length == 24; values >= 0
            if (hourly.Length == 24)
            {
                for (int i = 0; i < 24; i++) {
                    if (hourly[i] >= 0) {
                        HourlyKwh[i] = hourly[i];
                    }
                }
            }
        }
        public int Total()
        {
            int sum = 0;
            foreach (int i in HourlyKwh) { sum += i; }
            return sum;
        }
        
        public int PeakHour() {
            int maxValue = HourlyKwh[0];
            foreach (int i in HourlyKwh)
            {
                maxValue=Math.Max(maxValue, i);
            }
            return maxValue;
        }
        public void Display()
        {
            Console.WriteLine("Date -> "+Date);
            Console.WriteLine("Total: "+this.Total()+"kwh");   
            Console.WriteLine("PeakHour: "+this.PeakHour());
        }
    }
}
