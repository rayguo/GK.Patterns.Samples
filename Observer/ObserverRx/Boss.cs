using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverRx
{
    class Boss : IObserver<int>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Work completed");
        }

        public void OnNext(int value)
        {
            Console.WriteLine("Working on {0}", value);
        }

        public void OnError(Exception error) { }
    }
}
