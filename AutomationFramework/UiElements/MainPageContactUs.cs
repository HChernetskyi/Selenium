using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPageContactUs : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }
        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        private IWebElement ContactUsButton { get; set; }
        public void ContactUsButtonClick()
        {
            ContactUsButton.Click();
        }
        public bool ContactUsButtonEnabled()
        {
            return ContactUsButton.Enabled;
        }
        public MainPageContactUs()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
