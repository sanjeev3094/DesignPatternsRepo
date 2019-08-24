using System;

namespace DesignPatterns.Strategy.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Squeak >>");
        }
    }
}
