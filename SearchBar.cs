using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject___ebay_automation
{
    class SearchBar
    {
        public ChromeDriver chromeDriver;
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
        public SearchBar(ChromeDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }
        public IList<IWebElement> GetResult()
        {
            try
            {
                // Navigate to Url
                chromeDriver.Navigate().GoToUrl("https://www.ebay.com");

                // find elements with id = "gc-ac" (search bar) and put him <<productToSearch>>
                chromeDriver.FindElement(By.Id("gh-ac")).SendKeys(productToSearch);

                // find elements with id = "gh-btn" (search button) and click it
                chromeDriver.FindElement(By.Id("gh-btn")).Click();

                // Get all the list of search results of <<productToSearch>>
                IList<IWebElement> elements =
                    chromeDriver.FindElements(By.XPath("//div[contains(@class,'s-item__wrapper clearfix')]"));

                return elements;
            }
            finally
            {
                QuitDriver();
            }
        }
        public void QuitDriver()
        {
            chromeDriver.Quit();
        }
    }
}
