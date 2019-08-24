using System;

namespace DesignPatterns.Strategy.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly");
        }
    }
}
