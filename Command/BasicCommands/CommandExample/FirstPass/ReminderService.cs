using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CommandExample.FirstPass
{
    class ReminderService
    {
        // TODO: Use strategy to decouple from the console

        public void AddReminder(DateTime alarmTime)
        {
            TimeSpan deltaTime = alarmTime - DateTime.Now;
            Timer reminderTimer = new Timer(delegate
            {
                Console.Write("Your {0} Alarm Call", alarmTime);
            }, null, deltaTime, new TimeSpan(-1));
        }
    }
}
