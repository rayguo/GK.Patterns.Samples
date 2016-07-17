using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using CommandExample.SecondPass;

namespace CommandExample.ThirdPass
{
    class SoundReminderCommand : Command
    {
        IReminderStrategy _reminderStrategy;
        private string _message;
        private string _wavFile;

        public SoundReminderCommand(string message, string wavFile,
            IReminderStrategy reminderStrategy)
        {
            _message = message;
            _wavFile = wavFile;
            _reminderStrategy = reminderStrategy;
        }

        public override void Execute()
        {
            var player = new SoundPlayer(_wavFile);
            player.Play();
            _reminderStrategy.ReminderCall(_message);
        }
    }
}
