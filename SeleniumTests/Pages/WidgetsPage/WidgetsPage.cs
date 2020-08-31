using OpenQA.Selenium;

namespace SeleniumTests.Pages.WidgetsPage
{
    public class WidgetsPage : BasePage
    {
        public WidgetsPage(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement AutoCompleteButton => Driver.FindElement(By.XPath("//span[normalize-space(text())='Auto Complete']"));
        public IWebElement DatePickerButton => Driver.FindElement(By.XPath("//span[normalize-space(text())='Date Picker']"));


    }
}
