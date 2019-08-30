
namespace DesignPatterns.StatePattern.States
{
    /// <summary>
    /// These actions needs to be implemented by the states.
    /// </summary>
    public interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();
    }
}
