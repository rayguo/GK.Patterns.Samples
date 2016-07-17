using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CommandExample.ThirdPass
{
    class ReminderService
    {
        // Use strategy to decouple from the console
        public void AddReminder(DateTime alarmTime, 
            Command reminderCommand)
        {
            TimeSpan deltaTime = alarmTime - DateTime.Now;
            Timer reminderTimer = new Timer(delegate
            {
                //string text = string.Format("Your {0} Alarm Call", alarmTime);
                //reminderStrategy.ReminderCall(text);
                reminderCommand.Execute();
            }, null, deltaTime, new TimeSpan(-1));
        }
    }
}
