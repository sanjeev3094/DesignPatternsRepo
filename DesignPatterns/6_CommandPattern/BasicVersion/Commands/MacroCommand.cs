﻿using System;

namespace DesignPatterns.CommandPattern.BasicVersion.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands ?? throw new ArgumentNullException("Missing the commands array");
        }

        public void Execute()
        {
            foreach(ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            for(int i = _commands.Length - 1; i>=0; --i)
            {
                _commands[i].Undo();
            }
        }
    }
}
