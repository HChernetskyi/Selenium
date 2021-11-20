using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPageSignIn : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }
        
        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div.header_user_info > a")]
        private IWebElement SignInButton { get; set; }
        public bool SignInButtonEnabled()
        {
            return SignInButton.Enabled;
        }
        public void SignInButtonClick()
        {
            SignInButton.Click();
        }
        public MainPageSignIn()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
