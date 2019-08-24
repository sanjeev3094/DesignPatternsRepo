using DesignPatterns.CommandPattern.HomeAutomationDevices;
using System;

namespace DesignPatterns.CommandPattern.BasicVersion
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;
        private readonly int _volume;

        public StereoOnWithCDCommand(Stereo stereo, int volume)
        {
            _stereo = stereo ?? throw new ArgumentNullException(nameof(Stereo));
            _volume = volume;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(_volume);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
