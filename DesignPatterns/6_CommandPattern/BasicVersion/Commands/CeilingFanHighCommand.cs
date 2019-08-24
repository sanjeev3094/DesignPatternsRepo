using DesignPatterns.CommandPattern.HomeAutomationDevices;
using System;

namespace DesignPatterns.CommandPattern.BasicVersion.Commands
{
    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan)
            :base(ceilingFan) {}

        protected override void SetSpeed()
        {
            CeilingFan.High();
        }
    }
}
