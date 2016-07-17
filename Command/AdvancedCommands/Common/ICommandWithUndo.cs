using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public interface ICommandWithUndo
    {
        void Execute();
        void Undo();
    }
}
