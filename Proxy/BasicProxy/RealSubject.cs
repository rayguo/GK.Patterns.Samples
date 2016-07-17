using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProxy
{
    class RealSubject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("Real subject does something");
        }
    }
}
