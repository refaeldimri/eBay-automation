using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject___ebay_automation
{
    class HomePage
    {
        public SearchBar searchBar;

        public HomePage(IWebDriver iWebDriver)
        {
            searchBar = new SearchBar(iWebDriver);
        }
    }
}
