using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Test.Helpers;



namespace Test.Pages
{
    class HomePage
    {
        //navigate to TMpage()
        public void navigateToTM(IWebDriver driver)
        {

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            IWebElement TimeMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterials.Click();
        }
    }
}
