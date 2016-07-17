using System;
using System.IO;

namespace SingletonExamples.StaticClasses
{
    // No OOP goodness - can't extend existing class or be extended
    static class FileLogger //: Logger
    {
        private static readonly StreamWriter Writer
            = new StreamWriter("log.txt");

        public static void LogMessage(string message)
        {
            Writer.WriteLine(message);
            Writer.Flush();
        }
    }
}
