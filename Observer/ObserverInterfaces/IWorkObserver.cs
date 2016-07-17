using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverInterfaces
{
    interface IWorkObserver
    {
        void OnWorkStarted();
        void OnWorkProgressed(int item);
        void OnWorkCompleted();
    }
}
