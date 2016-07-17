using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProxy
{
    class Proxy : ISubject
    {
        private readonly ISubject _realSubject;

        public Proxy()
        {
            _realSubject = new RealSubject();
        }

        public void DoSomething()
        {
            Console.WriteLine("Proxy controls access to real subject.");
            _realSubject.DoSomething();
        }
    }
}
