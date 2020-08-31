using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests.Pages;
using SeleniumTests.Pages.WidgetsPage;
using SeleniumTests.Pages.WidgetsPage.Sections;
using SeleniumTests.Tests;

namespace SeleniumTests
{
    public class SeleniumTest : BaseTest
    {
        private HomePage _homePage;
        private WidgetsPage _widgetsPage;
        private AutocompleteSection _autocompleteSection;

        [SetUp]
        public void Setup()
        {
            Initalize();
            _homePage = new HomePage(Driver);
            _widgetsPage = new WidgetsPage(Driver);
            _autocompleteSection = new AutocompleteSection(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void OnlyGreenOptionIsShown()
        {
            _homePage.WidgetsButton.Click();
            _widgetsPage.AutoCompleteButton.Click();

            _autocompleteSection.TypeMultipleColorTextBox.SendKeys("Red");
            _autocompleteSection.TypeMultipleColorTextBox.SendKeys(Keys.Enter);

            _autocompleteSection.TypeMultipleColorTextBox.SendKeys("Re");
            
            Assert.IsTrue(_autocompleteSection.GreenSuggestionDiv.Displayed);
        }

    }
}