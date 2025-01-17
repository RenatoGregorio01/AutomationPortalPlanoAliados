using OpenQA.Selenium;
using AutomationTest.Drivers;
using Reqnroll.BoDi;

namespace AutomationTest.Tests
{
    public abstract class BaseTest : IDisposable
    {
        protected IWebDriver Driver { get; }
        protected IObjectContainer Container { get; }

        public BaseTest()
        {
            Driver = DriverFactory.CreateDriver();
            Container = new ObjectContainer();
            Container.RegisterInstanceAs<IWebDriver>(Driver);
        }

        public void Dispose()
        {
            Driver?.Quit();
        }
    }
}