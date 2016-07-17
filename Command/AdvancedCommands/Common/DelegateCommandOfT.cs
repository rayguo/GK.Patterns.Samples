using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DelegateCommand<TData> : ICommand<TData>
    {
        private readonly Action<TData> _action;

        public DelegateCommand(Action<TData> action)
        {
            _action = action;
        }

        public virtual void Execute(TData data)
        {
            _action(data);
        }
    }
}
