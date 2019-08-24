using System;
using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonTest()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Assert.AreSame(singleton1, singleton2);
        }
    }
}
