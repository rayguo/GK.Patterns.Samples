using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class DirectoryReport : ReportTemplate
    {
        private readonly string _directory;

        public DirectoryReport(string directory)
        {
            _directory = directory;
        }

        public override string GetTitle()
        {
            return string.Format("Report on Directory {0}", _directory);
        }

        public override string[] GetColumnNames()
        {
            return new[] {"Filename", "Created", "Last Modified"};
        }

        public override object[][] GetRows()
        {
            var query = from r in new DirectoryInfo(_directory).GetDirectories()
                select new object[] {r.Name, r.CreationTime, r.LastWriteTime};
            return query.ToArray();
        }
    }
}
