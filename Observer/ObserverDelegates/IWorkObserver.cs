using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDelegates
{
    interface IWorkObserver
    {
        void Subscribe(IObservableWorker worker);
        void Unsubscribe(IObservableWorker worker);
    }
}
