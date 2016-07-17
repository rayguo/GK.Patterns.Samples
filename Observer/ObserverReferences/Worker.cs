using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverReferences
{
    class Worker
    {
        Boss _observer;

        public Worker(Boss observer)
        {
            _observer = observer;
        }

        public void Work(int amount)
        {
            _observer.OnWorkStarted();
            for (int i = 0; i < amount; i++)
            {
                Thread.Sleep(400);
                _observer.OnWorkProgressed(i);
            }
            _observer.OnWorkCompleted();
        }
    }
}
