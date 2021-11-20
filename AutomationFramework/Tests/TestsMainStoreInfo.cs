using AutomationFramework.UiElements;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class TestsMainStoreInfo
    {        
        public string _expectedMainPageTitle = "My Store";
        public string _blockInfoLocationText = "Selenium Framework, Research Triangle Park, North Carolina, USA";
        public string _blockInfoPhoneNumber = "(347) 466-7432";
        public string _blockInfoEmailAddress = "support@seleniumframework.com";
        [Test, Category("Positive"), Description("Block \"Store information\" exist and enabled"), Order(12)]
        public void MainPageBlockInfoShown()
        {
            MainPageStoreInfo mainBlockInfo = new MainPageStoreInfo();
            mainBlockInfo.Open();
            Assert.IsTrue(mainBlockInfo.BlockInfoEnabled(), "\"Store information\" block is not enabled!");
        }

        [Test, Category("Positive"), Description("Block \"Store information\" contain Location"), Order(13)]
        public void BlockInfoLocationAddressShown()
        {
            MainPageStoreInfo mainBlockInfo = new MainPageStoreInfo();
            mainBlockInfo.Open();
            Assert.AreEqual(_blockInfoLocationText, mainBlockInfo.BlockInfoLocationAddressShown(), "Location address is not equal!");
        }

        [Test, Category("Positive"), Description("Block \"Store information\" contain phone"), Order(14)]
        public void BlockInfoLocationPhoneShown()
        {
            MainPageStoreInfo mainBlockInfo = new MainPageStoreInfo();
            mainBlockInfo.Open();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainBlockInfo.BlockInfoPhoneListElementDisplayed(), "The \"Store Information\" phone number item is not displayed!");
                Assert.AreEqual(_blockInfoPhoneNumber, mainBlockInfo.BlockInfoPhoneNumberShown(), "The \"Store Information\" block is not contain the right phone number!");
            });
        }

        [Test, Category("Positive"), Description("Block \"Store information\" contain email"), Order(15)]
        public void BlockInfoLocationEmailShown()
        {
            MainPageStoreInfo mainBlockInfo = new MainPageStoreInfo();
            mainBlockInfo.Open();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(mainBlockInfo.BlockInfoEmailListElementDisplayed(), "The \"Store Information\" email address is not displayed!");
                Assert.AreEqual(_blockInfoEmailAddress, mainBlockInfo.BlockInfoEmailHrefShown(), "The \"Store Information\" block is not contain the right Email address!");
            });
        }
    }
}