using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject___ebay_automation
{
    class EbayAutomation
    {
        public HomePage homePage;
        public EbayAutomation(IWebDriver iWebDriver)
        {
            this.homePage = new HomePage(iWebDriver);
        }
    }
}
