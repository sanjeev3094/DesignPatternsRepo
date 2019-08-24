
namespace DesignPatterns.Decorator.Component
{
    public abstract class Beverage
    {
        public abstract string Description { get; }

        public abstract double Cost();
    }
}
