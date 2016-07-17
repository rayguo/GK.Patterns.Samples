using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseFirstPass();
            //UseSecondPass();
            UseThirdPass();
        }

        private static void UseThirdPass()
        {
            var reminderService = new ThirdPass.ReminderService();
            while (true)
            {
                Console.Write("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                DateTime alarmTime = DateTime.Now.AddSeconds(seconds);

                string text = string.Format("Your {0} Alarm Call", alarmTime);
                string wavFile = string.Format(@"C:\Windows\Media\{0}", "tada.wav");
                
                ThirdPass.Command reminderCommand = 
                    new ThirdPass.SoundReminderCommand(text, wavFile,
                    new SecondPass.MessageBoxReminderStrategy());

                reminderService.AddReminder(alarmTime, reminderCommand);
            }
        }

        private static void UseSecondPass()
        {
            var reminderService = new SecondPass.ReminderService();
            while (true)
            {
                Console.Write("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                DateTime alarmTime = DateTime.Now.AddSeconds(seconds);

                reminderService.AddReminder(alarmTime,
                    new SecondPass.MessageBoxReminderStrategy());
            }
        }

        private static void UseFirstPass()
        {
            var reminderService = new FirstPass.ReminderService();
            while (true)
            {
                Console.Write("Remind in N seconds:");
                int seconds = int.Parse(Console.ReadLine());
                DateTime alarmTime = DateTime.Now.AddSeconds(seconds);

                reminderService.AddReminder(alarmTime);
            }
        }
    }
}
