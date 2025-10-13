using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment
{
    internal interface IDataIngestor
    {
        string Name { get; }
        IEnumerable<(DateTime ts, int kwh)> ReadBatch(int count);
    }
    internal class DlmsIngestor: IDataIngestor
    {
        public string Name { get; set; } = "DLMS";
        public IEnumerable<DateTime ts, int kwh> ReadBatch(int count)
        {

        }
    }
}
