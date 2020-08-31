using OpenQA.Selenium;

namespace SeleniumTests.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        public IWebDriver Driver { get; private set; }

        public void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void ScrollUp(int offset)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript($"window.scrollBy(0, -{offset});");
        }
    }


}
