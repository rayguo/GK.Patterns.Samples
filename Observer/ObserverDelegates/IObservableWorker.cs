using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDelegates
{
    interface IObservableWorker
    {
        event Action WorkStarted;
        event Action<int> WorkProgressed;
        event Action WorkCompleted;
    }
}
