using System;

namespace SingletonExamples.Lazy
{
    class Logger
    {
        private static readonly Logger Instance; // = new Logger();

        // Use type ctor to init pooled resource lazily
        static Logger()
        {
            Instance = new Logger();
        }

        // Only Logger can create a logger
        private Logger()
        {
            Console.WriteLine("Logger created");
            //throw new Exception("Oops");
        }

        // Return shared instance
        public static Logger GetInstance()
        {
            return Instance;
        }

        // Instance methods
        public void LogMessage(string message)
        {
#if DEBUG
            Console.WriteLine(message); 
#endif
        }
    }
}
