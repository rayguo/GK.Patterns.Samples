using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Invokers
{
    public class BasicInvoker
    {
        public void InvokeCommand(ICommand command)
        {
            Console.WriteLine("Pre-processing done here");

            command.Execute();

            Console.WriteLine("Post-processing done here");
        }
    }
}
