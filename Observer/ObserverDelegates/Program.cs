using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            var boss = new Boss();
            boss.Subscribe(worker);

            var coworker = new CoWorker();
            coworker.Subscribe(worker);

            worker.Work(5);
        }
    }
}
