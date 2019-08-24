using System;

namespace DesignPatterns.Strategy.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<< Silence >>>");
        }
    }
}
