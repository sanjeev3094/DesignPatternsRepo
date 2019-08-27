using System;
using DesignPatterns.AdapterAndFacade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class AdapterAndFacadeTests
    {
        [TestMethod]
        public void AdapterTest()
        {
            IDuck mallardDuck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck duck = new TurkeyAdapter(turkey);

            TestDuck(mallardDuck);
            TestDuck(duck);
        }

        private void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
