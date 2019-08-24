using DesignPatterns.Decorator.Component;
using System;

namespace DesignPatterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; }
        protected double Price { get; }
        protected string CondimentDescription { get; }

        protected CondimentDecorator(Beverage beverage, double price, string description)
        {
            Beverage = beverage ?? throw new ArgumentNullException(nameof(Beverage));
            Price = price;
            CondimentDescription = description;
        }
    }
}
