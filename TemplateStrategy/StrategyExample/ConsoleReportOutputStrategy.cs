using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    class ConsoleReportOutputStrategy : IReportOutputStrategy
    {
        public void PrintTitle(string title)
        {
            Console.WriteLine(title);
        }

        public void StartTable(string[] columns)
        {
            Console.WriteLine(string.Join(",", columns));
        }

        public void PrintRow(object[] row)
        {
            Console.WriteLine(string.Join(",", row));
        }

        public void PrintFooter(string footer)
        {
            Console.WriteLine(footer);
        }
    }
}
