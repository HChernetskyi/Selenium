using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPage : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }        
        public string GetPageTitle()
        {
            return Selenium.Driver.Title;
        }
        public string GetPageTitleUrl()
        {
            return Selenium.Driver.Url;
        }        
        public MainPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
