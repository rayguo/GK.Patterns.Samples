using System;
using System.Diagnostics;
using SingletonExamples.Simple;

namespace SingletonExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to use various singletons.

            //UseGlobalVariables();
            //UseStaticClasses();
            //UseSimple();
            //UseLazy();
            //BenchmarkSimpleLazy();
            //UseSimpleLazy();
            //UseWeakRef();
            //UseGeneric();
        }

        private static void UseGeneric()
        {
            var logger = Generic.Logger.GetInstance();
            logger.LogMessage("Hello");
        }

        private static void UseWeakRef()
        {
            var logger1 = WeakRef.Logger.GetInstance();
            logger1.LogMessage("Hello");
            var hash1 = logger1.GetHashCode();
            logger1 = null;
            GC.Collect();
            var logger2 = WeakRef.Logger.GetInstance();
            logger2.LogMessage("Hello");
            var hash2 = logger2.GetHashCode();
            Debug.Assert(hash1 != hash2);
        }

        private static void UseSimpleLazy()
        {
            // Both release and debug delay init
            Console.WriteLine("Going to use logger");
            SimpleLazy.Logger logger = SimpleLazy.Logger.GetInstance();
            logger.LogMessage("Hello");
        }

        private static void BenchmarkSimpleLazy()
        {
            // Make sure build set to Release

            Console.WriteLine("Simple:");
            long count = 1000000000;

            var sw1 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                UseSimple();
            }
            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);

            Console.WriteLine("\nLazy:");
            var sw2 = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                UseLazy();
            }
            sw2.Stop();
            Console.WriteLine(sw2.ElapsedMilliseconds);
        }

        private static void UseLazy()
        {
            // Both release and debug delay init
#if DEBUG
            Console.WriteLine("Going to use logger"); 
#endif
            Lazy.Logger logger = Lazy.Logger.GetInstance();
            logger.LogMessage("Hello");
        }

        private static void UseSimple()
        {
            // Release build: Logger created first
            // Debug build: Logger created when used
#if DEBUG
            Console.WriteLine("Going to use logger"); 
#endif
            Simple.Logger logger = Simple.Logger.GetInstance();
            logger.LogMessage("Hello");
        }

        private static void UseStaticClasses()
        {
            // No OOP goodness
            StaticClasses.FileLogger.LogMessage("Hello");
        }

        private static void UseGlobalVariables()
        {
            var logger1 = GlobalVariables.Global.Logger;

            // Nothing to prevent this
            var logger2 = new GlobalVariables.Logger();
        }
    }
}
