using System;

namespace StrategyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportTemplate report = new FileReport(@"c:\windows");
            //IReportOutputStrategy strategy = new ConsoleReportOutputStrategy();
            using (var strategy = new FileReportOutputStrategy(@"..\..\report.txt"))
            {
                report.ProduceReport(strategy);
            }            
        }
    }
}
