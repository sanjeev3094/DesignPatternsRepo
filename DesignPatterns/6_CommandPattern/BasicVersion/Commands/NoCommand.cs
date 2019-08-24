
namespace DesignPatterns.CommandPattern.BasicVersion
{
    /// <summary>
    /// This is a kind of null pattern.
    /// It helps in null checks.
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Execute() {}

        public void Undo() {}
    }
}
