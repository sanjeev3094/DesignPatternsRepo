
using System;
using System.Collections.Generic;

namespace DesignPatterns.CommandPattern.BasicVersion
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        private readonly int _totalSlots;

        private readonly Stack<ICommand> _commandStack = new Stack<ICommand>();

        public RemoteControl(int totalSlots)
        {
            _totalSlots = totalSlots;
            _onCommands = new ICommand[_totalSlots];
            _offCommands = new ICommand[_totalSlots];

            for(int i = 0; i < _totalSlots; ++i)
            {
                _onCommands[i] = new NoCommand();
                _offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            CheckSlot(slot);

            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            CheckSlot(slot);

            _onCommands[slot].Execute();
            _commandStack.Push(_onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            CheckSlot(slot);

            _offCommands[slot].Execute();
            _commandStack.Push(_offCommands[slot]);
        }

        public void UndoButtonWasPressed()
        {
            if (_commandStack.Count == 0)
                return;

            ICommand lastCommand = _commandStack.Pop();
            lastCommand.Undo();
        }

        private void CheckSlot(int slot)
        {
            if (slot < 0 || slot >= _totalSlots)
            {
                throw new ArgumentException("Incorrect slot");
            }
        }
    }
}
