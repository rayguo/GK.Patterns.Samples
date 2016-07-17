using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            UseBasicProxy();
        }

        private static void UseBasicProxy()
        {
            ISubject proxy = new Proxy();
            proxy.DoSomething();
        }
    }
}
