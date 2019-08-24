using DesignPatterns.Decorator.Component;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Mocha doesn't have existence without Espresso, HouseBlend etc...
    /// It decorates Espresso, etc.
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage, double price, string productDescription)
            : base(beverage, price, productDescription) { }

        public override string Description => $"{Beverage.Description}, {CondimentDescription}";

        public override double Cost()
        {
            return Beverage.Cost() + Price;
        }
    }
}
