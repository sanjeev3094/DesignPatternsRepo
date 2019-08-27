using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        /// <summary>
        /// This method acts as a hook.
        /// this method can be overriden by the subclass, if required
        /// </summary>
        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }

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
