using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDelegates
{
    class Boss : IWorkObserver
    {
        public void Subscribe(IObservableWorker worker)
        {
            worker.WorkStarted += OnWorkStarted;
            worker.WorkProgressed += OnWorkProgressed;
            worker.WorkCompleted += OnWorkCompleted;
        }

        public void Unsubscribe(IObservableWorker worker)
        {
            worker.WorkStarted -= OnWorkStarted;
            worker.WorkProgressed -= OnWorkProgressed;
            worker.WorkCompleted -= OnWorkCompleted;
        }

        public void OnWorkStarted()
        {
            Console.WriteLine("Boss: Work started");
        }

        public void OnWorkProgressed(int item)
        {
            Console.WriteLine("Boss: Working on {0}", item);
        }

        public void OnWorkCompleted()
        {
            Console.WriteLine("Boss: Work completed");
        }
    }
}
