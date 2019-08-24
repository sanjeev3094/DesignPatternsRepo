using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.BasicVersion;
using DesignPatterns.CommandPattern.BasicVersion.Commands;
using DesignPatterns.CommandPattern.HomeAutomationDevices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class CommandPatternTests
    {
        [TestMethod]
        public void SimpleCommandPatternTestMethod()
        {
            RemoteControl remoteControl = new RemoteControl(totalSlots: 7);

            Light livingRoomLight = new Light("Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(livingRoomCeilingFan);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.UndoButtonWasPressed();
        }

        [TestMethod]
        public void MacroCommandTestMethod()
        {
            Light livingRoomLight = new Light("Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(livingRoomCeilingFan);

            ICommand[] study = { livingRoomLightOn, ceilingFanHighCommand };
            ICommand[] stopStudy = { livingRoomLightOn, ceilingFanHighCommand };

            MacroCommand studyMacro = new MacroCommand(study);
            MacroCommand stopStudyMacro = new MacroCommand(stopStudy);

            RemoteControl remoteControl = new RemoteControl(totalSlots: 1);
            remoteControl.SetCommand(0, studyMacro, stopStudyMacro);

            remoteControl.OnButtonWasPushed(0);
        }
    }
}
