
namespace DesignPatterns.Decorator.Component
{
    public class HouseBlend : Beverage
    {
        private readonly double _price;
        private readonly string _description;

        public HouseBlend(double price, string description)
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
