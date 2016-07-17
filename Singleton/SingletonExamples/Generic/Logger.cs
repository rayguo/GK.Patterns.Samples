using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExamples.Generic
{
    sealed class Logger : Singleton<Logger>
    {
        // Prevent direct instantiation
        private Logger() { }

        // Allow only single instance
        public static Logger GetInstance()
        {
            return InternalGetInstance();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
