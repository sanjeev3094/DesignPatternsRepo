using DesignPatterns.CommandPattern.HomeAutomationDevices;
using System;

namespace DesignPatterns.CommandPattern.BasicVersion
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light ?? throw new ArgumentNullException(nameof(Light));
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
