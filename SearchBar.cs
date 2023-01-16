using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestProject___ebay_automation
{
    class SearchBar
    {
        public IWebDriver iWebDriver;
        private string productToSearch = "mouse";
        public string ProductToSearch   // property
        {
            get
            {
                if (productToSearch.Length == 0)
                {
                    productToSearch = "mouse";
                }
                return productToSearch;
            }   // get method
            set { productToSearch = value; }  // set method
        }
        public SearchBar(IWebDriver iWebDriver)
        {
            this.iWebDriver = iWebDriver;
        }
        public IList<IWebElement> GetResult()
        {
            try
            {
                // Navigate to Url
                iWebDriver.Navigate().GoToUrl("https://www.ebay.com");

                // find elements with id = "gc-ac" (search bar) and put him <<productToSearch>>
                iWebDriver.FindElement(By.Id("gh-ac")).SendKeys(productToSearch);

                // find elements with id = "gh-btn" (search button) and click it
                iWebDriver.FindElement(By.Id("gh-btn")).Click();

                // find input for price and put "50"
                iWebDriver.FindElement(By.XPath("//input[@class='textbox__control']")).SendKeys("50");

                // find price filter's button and click it
                iWebDriver.FindElement(By.XPath("//button[@title=\"Submit price range\"]")).Click();

                // Get all the list of search results of <<productToSearch>> after filtering
                IList<IWebElement> elements =
                    iWebDriver.FindElements(By.XPath("//div[@class=\"s-item__wrapper clearfix\"]"));
                return elements;
            }
            finally
            {
                QuitDriver();
            }
        }
        public void QuitDriver()
        {
            iWebDriver.Quit();
        }
    }
}
