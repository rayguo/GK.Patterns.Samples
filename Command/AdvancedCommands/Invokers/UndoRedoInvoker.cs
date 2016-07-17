using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Invokers
{
    public class UndoRedoInvoker
    {
        private Stack<ICommandWithUndo> _undoCommands = new Stack<ICommandWithUndo>();
        private Stack<ICommandWithUndo> _redoCommands = new Stack<ICommandWithUndo>();

        public void Execute(ICommandWithUndo cmd)
        {
            cmd.Execute();
            _undoCommands.Push(cmd);
        }
        public void Undo()
        {
            ICommandWithUndo cmd = _undoCommands.Pop();
            cmd.Undo();
            _redoCommands.Push(cmd);
        }
        public void Redo()
        {
            ICommandWithUndo cmd = _redoCommands.Pop();
            cmd.Execute();
            _undoCommands.Push(cmd);
        }
    }
}
