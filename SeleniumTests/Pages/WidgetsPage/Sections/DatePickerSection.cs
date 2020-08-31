using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTests.Pages.WidgetsPage.Sections
{
    public class DatePickerSection : BasePage

    {
        public DatePickerSection(IWebDriver driver) 
            : base(driver)
        {
        }
        public IWebElement SelectDateBox => Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
        public List<IWebElement> NotSelectedDay => Driver.FindElements(By.XPath("//div[@class='react-datepicker__week']//div[@tabindex='-1']")).ToList();
        public IWebElement SelectedDay => Driver.FindElement(By.XPath("//div[@class='react-datepicker__week']//div[@tabindex='0']"));


        public void AssertColorsAreCorrect(string expectedBackColor, string expectedColor, string actualSelectedDayBackColor,string actualSelectedColor)
        {
            Assert.AreEqual(expectedBackColor, actualSelectedDayBackColor);
            Assert.AreEqual(expectedColor, actualSelectedColor);
        }
    }
}
