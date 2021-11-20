using AutomationFramework.UiElements;
using NUnit.Framework;
using System;

namespace AutomationFramework.Tests
{
    public class TestsCart
    {
        [OneTimeSetUp]
        public void BeforeAlltests()
        {
            Selenium.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        public string _expectedOrderPageTitle = "Order - My Store";
        [Test, Category("Positive"), Description("\"Cart\" button enabled"), Order(6)]
        public void CartButtonEnabled()
        {
            MainPageCart mainPageCart = new MainPageCart();
            mainPageCart.Open();
            Assert.IsTrue(mainPageCart.CartButtonEnabled(), "\"Cart\" button is not enabled!");
        }

        [Test, Category("Positive"), Description("Work of the \"Cart\" button"), Order(7)]
        public void CartButtonClicked()
        {
            MainPageCart mainPageCart = new MainPageCart();
            mainPageCart.Open();
            mainPageCart.CartButtonClick();
            Assert.AreEqual(_expectedOrderPageTitle, Selenium.Driver.Title, "The title of page is not \"Order - My Store\"!");
        }
    }
}
