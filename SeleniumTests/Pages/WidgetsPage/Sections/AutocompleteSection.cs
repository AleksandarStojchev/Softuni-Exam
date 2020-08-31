using OpenQA.Selenium;

namespace SeleniumTests.Pages.WidgetsPage.Sections
{
    public class AutocompleteSection : BasePage
    {
        public AutocompleteSection(IWebDriver driver) 
            : base(driver)
        {
        }

        public IWebElement TypeMultipleColorTextBox => Driver.FindElement(By.XPath("//input[@id='autoCompleteMultipleInput']"));
        public IWebElement RedSuggestionDiv => Driver.FindElement(By.XPath("//div[normalize-space(text()) ='Red']"));
        public IWebElement GreenSuggestionDiv => Driver.FindElement(By.XPath("//div[normalize-space(text()) ='Green']"));


    }
}
