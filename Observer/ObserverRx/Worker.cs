using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverRx
{
    class Worker : IObservable<int>
    {
        List<IObserver<int>> _observers = new List<IObserver<int>>();

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new NullDisposable();
        }

        public void Work(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Thread.Sleep(400);
                NotifyOnNext(i);
            }
            NotifyOnComplete();
        }

        private void NotifyOnNext(int amount)
        {
            foreach (var observer in _observers)
                observer.OnNext(amount);
        }

        private void NotifyOnComplete()
        {
            foreach (var observer in _observers)
                observer.OnCompleted();
        }

        class NullDisposable : IDisposable
        {
            public void Dispose() { }
        }
    }
}
