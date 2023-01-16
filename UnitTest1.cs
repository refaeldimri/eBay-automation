using Guru99Demo;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestProject___ebay_automation
{
    public class Tests
    {
        BrowserFactory browserFactory;
        EbayAutomation ebayAutomation;

        [SetUp]
        public void Setup()
        {
             browserFactory = new BrowserFactory();
        }
        [Test]
        public void TestChrome()
        {
            browserFactory.InitBrowser("Chrome");
            ebayAutomation = new EbayAutomation(browserFactory.Drivers["CHROME"]);
            ebayAutomation.homePage.searchBar.ProductToSearch = "mouse";
            IList<IWebElement> elementsFromEbay = ebayAutomation.homePage.searchBar.GetResult();
            Assert.IsTrue(elementsFromEbay.Count > 0);
        }

        [Test]
        public void TestExploror()
        {
            browserFactory.InitBrowser("Ie");
            ebayAutomation = new EbayAutomation(browserFactory.Drivers["IE"]);
            ebayAutomation.homePage.searchBar.ProductToSearch = "mouse";
            IList<IWebElement> elementsFromEbay = ebayAutomation.homePage.searchBar.GetResult();
            Assert.IsTrue(elementsFromEbay.Count > 0);
        }

        [Test]
        public void TestFireFox()
        {
            browserFactory.InitBrowser("Firefox");
            ebayAutomation = new EbayAutomation(browserFactory.Drivers["FIREFOX"]);
            ebayAutomation.homePage.searchBar.ProductToSearch = "mouse";
            IList<IWebElement> elementsFromEbay = ebayAutomation.homePage.searchBar.GetResult();
            Assert.IsTrue(elementsFromEbay.Count > 0);
        }
    }
}