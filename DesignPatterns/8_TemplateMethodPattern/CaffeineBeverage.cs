using System;

namespace DesignPatterns.TemplateMethodPattern
{
    /// <summary>
    /// This class implements Template Design Pattern.
    /// </summary>
    public abstract class CaffeineBeverage
    {
        /// <summary>
        /// Template method,
        /// This serves as a template for an algorithm, in this case, an algorithm
        /// for making caffeinated beverages.
        /// </summary>
        public void PrepareRecipe()
        {
            // Each step of the algorithm is represented by a method.
            // Some methods are handled by this class and some are handled by the subclass.

            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();
       
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
