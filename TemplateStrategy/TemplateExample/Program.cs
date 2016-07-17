using System;

namespace TemplateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReportTemplate report = new FileReport(@"c:\windows");
            ReportTemplate report = new DirectoryReport(@"c:\windows");
            report.ProduceReport();
        }
    }
}
