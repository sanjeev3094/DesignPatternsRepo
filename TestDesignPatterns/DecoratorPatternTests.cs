using System;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Component;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class DecoratorPatternTests
    {
        [TestMethod]
        public void DecoratorPatternTest1()
        {
            Beverage beverage = new Espresso(price: 2, description: nameof(Espresso));
            Mocha mocha = new Mocha(beverage, 1, nameof(Mocha));
            Assert.AreEqual(mocha.Cost(), 3);
            Assert.AreEqual(mocha.Description, "Espresso, Mocha");
        }
    }
}
