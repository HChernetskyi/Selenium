using AutomationFramework.UiElements;
using NUnit.Framework;
using System;

namespace AutomationFramework.Tests
{
    public class TestsSearch
    {
        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            Selenium.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        public readonly string _expectedSearchPageTitle = "Search - My Store";
        public readonly string _validSearchKeyword = "Dress";
        public readonly string _messageValidSearch = " results have been found.";        
        public readonly string _messageEmptySearch = "Please enter a search keyword";
        public readonly string _messageInvalidSearch = "No results were found for your search";
        public readonly string _invalidSearchKeyword = "Bread123";
        
        [Test, Category("Positive"), Description("\"Search\" field exist and enabled"), Order(8)]
        public void SearchFieldExistAndEnabled()
        {            
            MainPageSearch search = new MainPageSearch();
            search.Open();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(search.SearchFieldEnabled(), "\"Search\" field is not enabled!");
                Assert.IsTrue(search.SearchFieldButtonEnabled(), "\"Search\" button is not enabled!");
            });
        }

        [Test, Category("Positive"), Description("Work of the \"Search\" function with valid keyword"), Order(9)]
        public void SearchWithValidKeyword()
        {
            MainPageSearch search = new MainPageSearch();
            search.Open();            
            search.SearchByKeyword(_validSearchKeyword);                                    
            Assert.Multiple(() =>
            {
                Assert.AreEqual(_expectedSearchPageTitle, Selenium.Driver.Title, "The title of page is not \"Search - My Store\"!");
                Assert.Greater(search.SearchResultQuantity(), 0, "Search request does not have any result(s)");
            });
        }

        [Test, Category("Negative"), Description("Work of the \"Search\" function with invalid keyword"), Order(10)]
        public void SearchWithInvalidKeyword()
        {
            MainPageSearch search = new MainPageSearch();
            search.Open();            
            search.SearchByKeyword(_invalidSearchKeyword);
            Assert.AreEqual(_messageInvalidSearch + " \"" + _invalidSearchKeyword + "\"", search.SearchFieldResultStringText(), "String message for invalid search is not equal.");
        }

        [Test, Category("Negative"), Description("Work of the \"Search\" function without any keyword"), Order(11)]
        public void SearchWithEmptyRequest()
        {
            MainPageSearch search = new MainPageSearch();            
            search.SearchByKeyword("");
            Assert.AreEqual(_messageEmptySearch, search.SearchFieldResultStringText(), "String message for empty search is not equal.");
        }
    }
}