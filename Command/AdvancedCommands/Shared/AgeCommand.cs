using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class AgeCommand : ICommand
    {
        private readonly Person _target;

        public AgeCommand(Person target)
        {
            _target = target;
        }

        public void Execute()
        {
            _target.Age++;
        }
    }
}
