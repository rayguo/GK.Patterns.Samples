using System;

namespace SingletonExamples.SimpleLazy
{
    class Logger
    {
        private static Logger _instance; //= new Logger();

        // Only Logger can create a logger
        private Logger()
        {
            Console.WriteLine("Logger created");
            //throw new Exception("Oops");
        }

        // Return shared instance
        public static Logger GetInstance()
        {
            // Create static resource once
            // NOTE: potential race condition
            if (_instance == null)
            {
                _instance = new Logger();
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
