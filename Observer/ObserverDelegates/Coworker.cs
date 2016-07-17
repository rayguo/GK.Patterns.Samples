using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDelegates
{
    class CoWorker : IWorkObserver
    {
        public void Subscribe(IObservableWorker worker)
        {
            worker.WorkCompleted += OnWorkCompleted;
        }

        public void Unsubscribe(IObservableWorker worker)
        {
            worker.WorkCompleted -= OnWorkCompleted;
        }

        public void OnWorkCompleted()
        {
            Console.WriteLine("Coworker: Work completed");
        }
    }
}
