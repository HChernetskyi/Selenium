using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class MainPageSearch : BasePage
    {
        public override string Url { get => "http://automationpractice.com/index.php"; }
                
        [FindsBy(How = How.CssSelector, Using = "#search_query_top")]
        private IWebElement SearchField { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#searchbox > button")]
        private IWebElement SearchFieldButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#center_column > h1 > span.heading-counter")]
        private IWebElement SearchFieldResultCounterString { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#center_column > p")]
        private IWebElement SearchFieldResultString { get; set; }
        public void SearchByKeyword(string keyword)
        {
            SearchField.Clear();
            SearchField.SendKeys(keyword);
            SearchFieldButton.Click();
        }
        public bool SearchFieldEnabled()
        {
            return SearchField.Enabled;
        }
        public bool SearchFieldButtonEnabled()
        {
            return SearchFieldButton.Enabled;
        }
        public int SearchResultQuantity()
        {
            int indexOfSpace = SearchFieldResultCounterString.Text.IndexOf(' ');
            int _searchResultQuantity = int.Parse(SearchFieldResultCounterString.Text.Remove(indexOfSpace, SearchFieldResultCounterString.Text.Length - indexOfSpace));     //find quantity of result(s)
            return _searchResultQuantity;
        }
        public string SearchFieldResultStringText()
        {
            return SearchFieldResultString.Text;
        }
        public MainPageSearch()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
