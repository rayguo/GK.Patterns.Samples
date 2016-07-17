using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandExample.SecondPass
{
    interface IReminderStrategy
    {
        void ReminderCall(string text);
    }
}
