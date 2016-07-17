using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverDelegates
{
    class Worker : IObservableWorker
    {
        public event Action WorkStarted;
        public event Action<int> WorkProgressed;
        public event Action WorkCompleted;

        public void Work(int amount)
        {
            if (WorkStarted != null)
                WorkStarted();

            for (int i = 0; i < amount; i++)
            {
                Thread.Sleep(400);

                if (WorkProgressed != null)
                    WorkProgressed(i);
            }

            if (WorkCompleted != null)
                WorkCompleted();
        }
    }
}
