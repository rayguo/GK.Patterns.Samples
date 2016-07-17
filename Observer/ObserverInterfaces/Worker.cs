using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverInterfaces
{
    class Worker
    {
        //Boss _observer;
        IWorkObserver[] _observers;

        public Worker(params IWorkObserver[] observers)
        {
            _observers = observers;
        }

        public void Work(int amount)
        {
            foreach (var observer in _observers)
                observer.OnWorkStarted();

            for (int i = 0; i < amount; i++)
            {
                Thread.Sleep(400);

                foreach(var observer in _observers)
                    observer.OnWorkProgressed(i);
            }

            foreach (var observer in _observers) 
                observer.OnWorkCompleted();
        }
    }
}
