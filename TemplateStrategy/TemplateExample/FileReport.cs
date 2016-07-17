using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class FileReport : ReportTemplate
    {
        private readonly string _directory;

        public FileReport(string directory)
        {
            _directory = directory;
        }

        public override string GetTitle()
        {
            return string.Format("Report on Directory {0}", _directory);
        }

        public override string[] GetColumnNames()
        {
            return new[] {"Filename", "Size", "Last Modified"};
        }

        public override object[][] GetRows()
        {
            var query = from r in new DirectoryInfo(_directory).GetFiles()
                select new object[] {r.Name, r.Length, r.LastWriteTime};
            return query.ToArray();
        }
    }
}
