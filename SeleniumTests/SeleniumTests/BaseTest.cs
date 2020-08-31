using AutoFixture;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace SeleniumTests.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }
        public Actions Builder { get; private set; }
        public Fixture Fixture => new Fixture();

        public void Initalize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.demoqa.com/";

            Builder = new Actions(Driver);
        }
    }
}
