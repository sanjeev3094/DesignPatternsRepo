
namespace DesignPatterns.Decorator.Component
{
    public class Espresso : Beverage
    {
        private readonly double _price;
        private readonly string _description;

        public Espresso(double price, string description)
        {
            _price = price;
            _description = description;
        }

        public override string Description => _description;

        public override double Cost()
        {
            return _price;
        }
    }
}
