using OpenQA.Selenium;

namespace SeleniumTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public IWebElement WidgetsButton => Driver.FindElement(By.XPath("//div/h5[normalize-space(text())='Widgets']"));
    }
}
