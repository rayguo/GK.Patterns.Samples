using System;
using System.Collections.Generic;
using System.IO;

namespace StrategyExample
{
    class FileReportOutputStrategy : IReportOutputStrategy, IDisposable
    {
        private readonly StreamWriter _streamWriter;

        public FileReportOutputStrategy(string path)
        {
            _streamWriter = new StreamWriter(path);
        }
        public void PrintTitle(string title)
        {
            _streamWriter.WriteLine(title);
        }

        public void StartTable(string[] columns)
        {
            _streamWriter.WriteLine(string.Join(",", columns));
        }

        public void PrintRow(object[] row)
        {
            _streamWriter.WriteLine(string.Join(",", row));
        }

        public void PrintFooter(string footer)
        {
            _streamWriter.WriteLine(footer);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}
