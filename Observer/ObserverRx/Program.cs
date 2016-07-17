using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverRx
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Boss();
            var worker = new Worker();

            worker.Subscribe(boss);

            worker.Work(5);
        }
    }
}
