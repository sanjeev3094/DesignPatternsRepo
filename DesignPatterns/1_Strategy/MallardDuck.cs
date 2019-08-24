using DesignPatterns.Strategy.Behaviors;
using System;

namespace DesignPatterns.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        {
            _Name = "Mallard Duck";
        }

        protected override void Description()
        {
            Console.WriteLine($"I am {_Name}");
        }
    }
}
