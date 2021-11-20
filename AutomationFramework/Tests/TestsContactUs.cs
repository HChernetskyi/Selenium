using AutomationFramework.UiElements;
using NUnit.Framework;
using System;

namespace AutomationFramework.Tests
{
    public class TestsContactUs
    {
        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            Selenium.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
                
        public string _expectedContactUsPageTitle = "Contact us - My Store";
        [Test, Category("Positive"), Description("\"Contact us\" button exist and enabled"), Order(4)]
        public void ContactUsButtonExistAndEnabled()
        {
            MainPageContactUs mainPageContactUs = new MainPageContactUs();
            mainPageContactUs.Open();
            Assert.IsTrue(mainPageContactUs.ContactUsButtonEnabled(), "\"Contact us\" button is not enabled!");
        }

        [Test, Category("Positive"), Description("Work of the \"Contact us\" button"), Order(5)]
        public void ContactUsButtonClicked()
        {
            MainPageContactUs mainPageContactUs = new MainPageContactUs();
            mainPageContactUs.Open();
            mainPageContactUs.ContactUsButtonClick();
            Assert.AreEqual(_expectedContactUsPageTitle, Selenium.Driver.Title, "The title of page is not \"" + _expectedContactUsPageTitle + "\"!");
        }
    }
}