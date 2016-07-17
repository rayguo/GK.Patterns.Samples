using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Boss();
            var coworker = new Coworker();
            var worker = new Worker(boss, coworker);
            worker.Work(5);
        }
    }
}
