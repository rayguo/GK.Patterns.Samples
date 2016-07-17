using System;
using System.Security.Principal;

namespace TemplateExample
{
    abstract class ReportTemplate
    {
        public void ProduceReport()
        {
            Console.WriteLine(GetTitle());

            Console.WriteLine(string.Join(",", GetColumnNames()));


            foreach (object[] row in GetRows())
            {
                Console.WriteLine(string.Join(",", row));
            }

            Console.WriteLine("Report Produced {0} by {1}",
              DateTime.Now,
              WindowsIdentity.GetCurrent().Name);
        }

        public abstract string GetTitle();
        public abstract string[] GetColumnNames();
        public abstract object[][] GetRows();
    }
}
