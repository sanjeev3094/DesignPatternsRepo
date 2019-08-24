using DesignPatterns.CommandPattern.HomeAutomationDevices;
using System;

namespace DesignPatterns.CommandPattern.BasicVersion
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light ?? throw new ArgumentNullException(nameof(Light));
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
