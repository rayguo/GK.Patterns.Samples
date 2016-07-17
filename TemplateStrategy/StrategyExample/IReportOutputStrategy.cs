using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    interface IReportOutputStrategy
    {
        void PrintTitle(string title);
        void StartTable(string[] columns);
        void PrintRow(object[] row);
        void PrintFooter(string footer);
    }
}
