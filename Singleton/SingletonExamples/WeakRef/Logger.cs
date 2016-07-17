using System;

namespace SingletonExamples.WeakRef
{
    class Logger
    {
        //private static Logger _instance;
        private static WeakReference _weakInstance
            = new WeakReference(null);

        private static readonly object SharedLock = new object();

        // Only Logger can create a logger
        private Logger()
        {
            Console.WriteLine("Logger created");
        }

        // Return shared instance
        public static Logger GetInstance()
        {
            // Get strong instance
            var strongInstance = (Logger)_weakInstance.Target;
            if (strongInstance == null)
            {
                lock (SharedLock)
                {
                    if (strongInstance == null)
                    {
                        // Set strong and weak instance
                        strongInstance = new Logger();
                        _weakInstance = new WeakReference(strongInstance);
                    }
                } 
            }

            return strongInstance;
        }

        // Instance methods
        public void LogMessage(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
