using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests.Pages;
using SeleniumTests.Pages.WidgetsPage;
using SeleniumTests.Pages.WidgetsPage.Sections;
using SeleniumTests.Tests;
using System;

namespace SeleniumTests.SeleniumTests.DatePickerTests
{
    public class DatePickerTests : BaseTest
    {
        private HomePage _homePage;
        private WidgetsPage _widgetsPage;
        private DatePickerSection _datepickerSection;
        Random rnd = new Random();

        

        [SetUp]
        public void Setup()
        {
            Initalize();
            _homePage = new HomePage(Driver);
            _widgetsPage = new WidgetsPage(Driver);
            _datepickerSection = new DatePickerSection(Driver);


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }


        //2.2 Date Picker 

        //	10 points  Task
        [Test]
        public void SelectedDayColorsAreCorrect()
        {
            string expectedBackColor = "rgba(33, 107, 165, 1)";
            string expectedColor = "rgba(255, 255, 255, 1)";

            RandomDateSelect();

            var actualSelectedDayBackColor = _datepickerSection.SelectedDay
                .GetCssValue("background-color");
            var actualSelectedColor = _datepickerSection.SelectedDay.
                GetCssValue("color");


            _datepickerSection.AssertColorsAreCorrect(expectedBackColor, expectedColor, 
                actualSelectedDayBackColor, actualSelectedColor);


        }
        // 15 points Task
        [Test]
        public void HoverSelectedDayColorsAreCorrect()
        {
            string expectedBackColor = "rgba(29, 93, 144, 1)";
            string expectedColor = "rgba(255, 255, 255, 1)";

            RandomDateSelect();
            int randomNumberForDay = rnd.Next(0, _datepickerSection.NotSelectedDay.Count - 1);

            Builder.MoveToElement(_datepickerSection.NotSelectedDay[randomNumberForDay]).Perform();
            Builder.MoveToElement(_datepickerSection.SelectedDay).Perform();


            var actualSelectedDayBackColor = _datepickerSection.SelectedDay
                .GetCssValue("background-color");
            var actualSelectedColor = _datepickerSection.SelectedDay
                .GetCssValue("color");


            _datepickerSection.AssertColorsAreCorrect(expectedBackColor, expectedColor, 
                actualSelectedDayBackColor, actualSelectedColor);

        }
        //  20 points Task
        [Test]
        public void HoverNOTSelectedDayColorsAreCorrect()
        {
            string expectedBackColor = "rgba(240, 240, 240, 1)";
            string expectedColor = "rgba(0, 0, 0, 1)";

            RandomDateSelect();
            int randomNumberForDay = rnd.Next(0, _datepickerSection.NotSelectedDay.Count - 1);

            Builder.MoveToElement(_datepickerSection.NotSelectedDay[randomNumberForDay]).Perform();

            var actualSelectedDayBackColor = _datepickerSection.NotSelectedDay[randomNumberForDay].GetCssValue("background-color");
            var actualSelectedColor = _datepickerSection.NotSelectedDay[randomNumberForDay].GetCssValue("color");

            _datepickerSection.AssertColorsAreCorrect(expectedBackColor, expectedColor, 
                actualSelectedDayBackColor, actualSelectedColor);
        }

        public void RandomDateSelect()
        {
            var date = Fixture.Create<DateTime>();
            string randomDateCurrentYear = new DateTime(2020, date.Month, date.Day).ToString();

            _homePage.WidgetsButton.Click();
            _widgetsPage.DatePickerButton.Click();

            _datepickerSection.SelectDateBox.SendKeys(Keys.Control + "a" + Keys.Backspace);

            _datepickerSection.SelectDateBox.SendKeys(randomDateCurrentYear);
        }
    }
}
