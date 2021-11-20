using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPageStoreInfo : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }
        /* block "Store information" elements */
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos")]
        private IWebElement BlockInfo { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos > div > ul > li:nth-child(1)")]
        private IWebElement BlockInfoLocationAddress { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos > div > ul > li:nth-child(2)")]
        private IWebElement BlockInfoPhoneListElement { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos > div > ul > li:nth-child(2) > span")]
        private IWebElement BlockInfoPhoneNumber { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos > div > ul > li:nth-child(3)")]
        private IWebElement BlockInfoEmailListElement { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_contact_infos > div > ul > li:nth-child(3) > span > a")]
        private IWebElement BlockInfoEmailHref { get; set; }
        public bool BlockInfoEnabled()
        {
            return BlockInfo.Enabled;            
        }
        public string BlockInfoLocationAddressShown()
        {
            return BlockInfoLocationAddress.Text;
        }
        public bool BlockInfoPhoneListElementDisplayed()
        {
            return BlockInfoPhoneListElement.Displayed;            
        }
        public string BlockInfoPhoneNumberShown()
        {
            return BlockInfoPhoneNumber.Text;
        }
        public bool BlockInfoEmailListElementDisplayed()
        {
            return BlockInfoEmailListElement.Displayed;            
        }
        public string BlockInfoEmailHrefShown()
        {
            return BlockInfoEmailHref.Text;
        }
        public MainPageStoreInfo()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
