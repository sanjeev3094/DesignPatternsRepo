using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy.Behaviors;

namespace DesignPatterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
            _Name = "Rubber Duck";
        }

        protected override void Description()
        {
            Console.WriteLine($"I'm a {_Name}");
        }
    }
}
