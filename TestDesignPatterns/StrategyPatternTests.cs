using System;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Behaviors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class StrategyPatternTests
    {
        [TestMethod]
        public void TestFlyingBird()
        {
            Duck duck = new MallardDuck(new FlyWithWings(), new Quack());
            duck.Quack();
            duck.Fly();
        }

        [TestMethod]
        public void TestNoFlyingMuteBird()
        {
            Duck duck = new MallardDuck(new FlyNoWay(), new MuteQuack());
            duck.Quack();
            duck.Fly();
        }
    }
}
