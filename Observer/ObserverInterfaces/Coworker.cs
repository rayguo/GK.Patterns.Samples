using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverInterfaces
{
    class Coworker : IWorkObserver
    {
        public void OnWorkStarted()
        {
            Console.WriteLine("Coworker: Work started");
        }

        public void OnWorkProgressed(int item)
        {
            Console.WriteLine("Coworker: Working on {0}", item);
        }

        public void OnWorkCompleted()
        {
            Console.WriteLine("Coworker: Work completed");
        }
    }
}
