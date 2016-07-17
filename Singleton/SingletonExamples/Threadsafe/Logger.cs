using System;

namespace SingletonExamples.Threadsafe
{
    class Logger
    {
        private static Logger _instance; //= new Logger();

        private static readonly object SharedLock = new object();

        // Only Logger can create a logger
        private Logger()
        {
            Console.WriteLine("Logger created");
        }

        // Return shared instance
        public static Logger GetInstance()
        {
            // Only pay sync price 1st time w double check
            if (_instance == null)
            {
                // Not granular enough w/o double check
                lock (SharedLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                } 
            }

            return _instance;
        }

        // Instance methods
        public void LogMessage(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
