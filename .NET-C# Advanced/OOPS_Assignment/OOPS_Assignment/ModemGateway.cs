using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal class ModemGateway(string id):IReadable
    {
        public string SourceId { get; set; } = id;
        public int ReadKwh()
        {
            Random random = new Random();
            int number=random.Next(0, 2);
            return number;
        }
    }
}
