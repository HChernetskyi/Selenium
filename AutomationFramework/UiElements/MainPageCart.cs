using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPageCart : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }
        
        [FindsBy(How = How.CssSelector, Using = "#header > div:nth-child(3) > div > div > div:nth-child(3) > div > a")]
        private IWebElement CartButton { get; set; }
        public bool CartButtonEnabled()
        {
            return CartButton.Enabled;
        }
        public void CartButtonClick()
        {
            CartButton.Click();
        }
        public MainPageCart()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
