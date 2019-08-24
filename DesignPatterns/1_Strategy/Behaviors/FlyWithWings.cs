using System;

namespace DesignPatterns.Strategy.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!!!");
        }
    }
}
