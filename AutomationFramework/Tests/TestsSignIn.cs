using AutomationFramework.UiElements;
using NUnit.Framework;
using System;

namespace AutomationFramework.Tests
{
    public class TestsSignIn
    {
        public string _expectedLoginPageTitle = "Login - My Store";
        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            Selenium.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Test, Category("Positive"), Description("\"Sign in\" button exist and enabled"), Order(2)]
        public void PositiveTestSignInButtonExistAndEnabled()
        {            
            MainPageSignIn mainSignIn = new MainPageSignIn();
            mainSignIn.Open();
            Assert.IsTrue(mainSignIn.SignInButtonEnabled(), "\"Sign in\" button is not enabled!");            
        }

        [Test, Category("Positive"), Description("Work of the \"Sign in\" button"), Order(3)]
        public void PositiveTestSignInButtonClicked()
        {
            MainPageSignIn mainSignIn = new MainPageSignIn();
            mainSignIn.Open();
            mainSignIn.SignInButtonClick();
            Assert.AreEqual(_expectedLoginPageTitle, Selenium.Driver.Title, "The title of page is not \"Login - My Store\"!");
        }
    }
}