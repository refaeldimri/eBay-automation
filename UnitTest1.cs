using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace TestProject___ebay_automation
{
    public class Tests
    {
        ChromeDriver chromeDriver = new ChromeDriver();
        EbayAutomation ebayAutomation;
        [SetUp]
        public void Setup()
        {
            ebayAutomation = new EbayAutomation(chromeDriver);
        }

        [Test]
        public void Test()
        {
            ebayAutomation.homePage.searchBar.ProductToSearch = "mouse";
            IList<IWebElement> elementsFromEbay = ebayAutomation.homePage.searchBar.GetResult();
            Assert.IsTrue(elementsFromEbay.Count > 0);
        }
    }
}