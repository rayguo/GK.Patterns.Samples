using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CommandExample.SecondPass
{
    class ReminderService
    {
        // Use strategy to decouple from the console
        public void AddReminder(DateTime alarmTime, 
            IReminderStrategy reminderStrategy)
        {
            TimeSpan deltaTime = alarmTime - DateTime.Now;
            Timer reminderTimer = new Timer(delegate
            {
                string text = string.Format("Your {0} Alarm Call", alarmTime);
                reminderStrategy.ReminderCall(text);
            }, null, deltaTime, new TimeSpan(-1));
        }
    }
}
