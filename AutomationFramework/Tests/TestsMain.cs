using AutomationFramework.UiElements;
using NUnit.Framework;
using System;

namespace AutomationFramework.Tests
{
    public class TestsMain
    {
        readonly string _expectedMainPageTitle = "My Store";
        readonly string _expectedMainPageUrl = "http://automationpractice.com/index.php";
        [OneTimeSetUp]
        public void BeforeAlltests()
        {
            Selenium.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }        
        
        [Test, Description("User can open the main page"), Order(1)]
        public void PageCanBeOpened()
        {            
            MainPage mainPage = new MainPage();
            mainPage.Open();
            string _mainPageTitle = mainPage.GetPageTitle();
            string _mainPageTitleUrl = mainPage.GetPageTitleUrl();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(_expectedMainPageTitle, _mainPageTitle, "Title is not match");
                Assert.AreEqual(_expectedMainPageUrl, _mainPageTitleUrl, "Url is not match");
            });            
        }
    }
}