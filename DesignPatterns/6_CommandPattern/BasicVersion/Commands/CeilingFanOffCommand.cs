using DesignPatterns.CommandPattern.HomeAutomationDevices;

namespace DesignPatterns.CommandPattern.BasicVersion.Commands
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
            : base(ceilingFan) {}

        protected override void SetSpeed()
        {
            CeilingFan.Off();
        }
    }
}
