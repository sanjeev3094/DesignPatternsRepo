using System;

namespace DesignPatterns.CommandPattern
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Action _undoExecute;

        public RelayCommand(Action execute, Action undoExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _undoExecute = undoExecute ?? throw new ArgumentNullException(nameof(undoExecute));
        }

        public void Execute()
        {
            _execute();
        }

        public void Undo()
        {
            _undoExecute();
        }
    }
}
