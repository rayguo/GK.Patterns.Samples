using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandExample.SecondPass
{
    class MessageBoxReminderStrategy : IReminderStrategy
    {
        public void ReminderCall(string text)
        {
            MessageBox.Show(text, "Reminder");
        }
    }
}
