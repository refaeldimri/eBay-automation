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
        public EbayAutomation(ChromeDriver chromeDriver)
        {
            this.homePage = new HomePage(chromeDriver);
        }
    }
}
