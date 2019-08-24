using System;

namespace DesignPatterns.Strategy.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
