using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public virtual void Execute()
        {
            _action();
        }
    }
}
