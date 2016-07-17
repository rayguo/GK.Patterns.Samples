using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Boss();
            var worker = new Worker(boss);
            worker.Work(5);
        }
    }
}
