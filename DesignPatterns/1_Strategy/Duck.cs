
using DesignPatterns.Strategy.Behaviors;
using System;

namespace DesignPatterns.Strategy
{
    public abstract class Duck
    {
        protected string _Name;
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior ?? throw new ArgumentNullException(nameof(IFlyBehavior));
            _quackBehavior = quackBehavior ?? throw new ArgumentNullException(nameof(IQuackBehavior));
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        protected abstract void Description();
    }
}
