using System;

namespace DesignPatterns.StatePattern.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.CurrentState = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.CurrentState = _gumballMachine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
