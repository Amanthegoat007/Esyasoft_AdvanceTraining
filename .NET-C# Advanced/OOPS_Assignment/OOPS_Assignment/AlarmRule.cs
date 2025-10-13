using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    public abstract class AlarmRule(string name)
    {
        public string Name { get; } = name;
        //protected AlarmRule(string name)=>Name=name;
        public abstract bool IsTriggered(LoadProfileDay day);
        public virtual string Message(LoadProfileDay day) => $"{Name} triggered on {day.Date:yyyy-MM-dd}";
    }
    public class PeakOveruseRule: AlarmRule
    {
        private readonly int _threshold;
        public PeakOveruseRule(int threshold) : base("PeakOveruse")=> _threshold = threshold;
        public override bool IsTriggered(LoadProfileDay day) => day.Total() > _threshold;
    }
    public class SustainedOutageRule: AlarmRule {
        private readonly int _minConsecutive;
        public SustainedOutageRule(int min):base("SustainedOutage")=>_minConsecutive = min;
        public override bool IsTriggered(LoadProfileDay day){
            int n = 0;
            int maxi = 0;
            foreach(int i in day.HourlyKwh){
                if (i == 0) { n++; maxi = Math.Max(maxi, n); }
                else n = 0;
            }

            return _minConsecutive>=maxi;
    }
}
