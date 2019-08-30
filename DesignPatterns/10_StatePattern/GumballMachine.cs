using DesignPatterns.StatePattern.States;
using System;

namespace DesignPatterns.StatePattern
{
    /// <summary>
    /// GumballMachine represents the Context
    /// and Context is in one of the states.
    /// </summary>
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }

        public IState CurrentState { get; set; }

        public int Count { get; private set; }

        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            Count = numberOfGumballs;
            if(Count > 0)
            {
                CurrentState = NoQuarterState;
            }
            else
            {
                CurrentState = SoldOutState;
            }
        }

        public void InsertQuater()
        {
            CurrentState.InsertQuarter();
        }

        public void EjectQuater()
        {
            CurrentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if(Count > 0)
            {
                Count = Count - 1;
            }
        }
    }
}
