using System;
using System.Security.Principal;

namespace StrategyExample
{
    abstract class ReportTemplate
    {
        public void ProduceReport(IReportOutputStrategy outputStrategy)
        {
            //Console.WriteLine(GetTitle());
            outputStrategy.PrintTitle(GetTitle());

            //Console.WriteLine(string.Join(",", GetColumnNames()));
            outputStrategy.StartTable(GetColumnNames());


            foreach (object[] row in GetRows())
            {
                //Console.WriteLine(string.Join(",", row));
                outputStrategy.PrintRow(row);
            }

            //Console.WriteLine("Report Produced {0} by {1}",
            //  DateTime.Now,
            //  WindowsIdentity.GetCurrent().Name);
            string footer = string.Format("Report Produced {0} by {1}",
                DateTime.Now,
                WindowsIdentity.GetCurrent().Name);
            outputStrategy.PrintFooter(footer);
        }

        public abstract string GetTitle();
        public abstract string[] GetColumnNames();
        public abstract object[][] GetRows();
    }
}
