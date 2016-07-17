using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandExample.SecondPass
{
    class ConsoleReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            Console.WriteLine(text);
        }
    }
}
