using System;

namespace DesignPatterns.AdapterAndFacade
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
