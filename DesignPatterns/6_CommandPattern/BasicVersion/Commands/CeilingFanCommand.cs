using DesignPatterns.CommandPattern.HomeAutomationDevices;
using System;

namespace DesignPatterns.CommandPattern.BasicVersion.Commands
{
    public abstract class CeilingFanCommand : ICommand
    {
        private Speed _prevSpeed;

        protected CeilingFan CeilingFan { get; }

        public CeilingFanCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan ?? throw new ArgumentNullException(nameof(CeilingFan));
        }

        public void Execute()
        {
            _prevSpeed = CeilingFan.Speed;
            SetSpeed();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case Speed.High:
                    CeilingFan.High();
                    break;
                case Speed.Medium:
                    CeilingFan.Medium();
                    break;
                case Speed.Low:
                    CeilingFan.Low();
                    break;
                case Speed.Off:
                    CeilingFan.Off();
                    break;
            }
        }

        protected abstract void SetSpeed();
    }
}
