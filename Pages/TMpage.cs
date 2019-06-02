using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Test.Helpers;

namespace Test.Pages
{
    class TMpage
    {


        public void AddTM(IWebDriver driver)
        {
            //Click on 'Create new' button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            TypeCode.Click();

            //IWebElement TypeCode_Time = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            //TypeCode_Time.Click();

            //Enter code
            IWebElement Code = driver.FindElement(By.XPath("//*[@id='Code']"));
            Code.SendKeys("AutomationTesting");

            //Enter the description
            driver.FindElement(By.Id("Description")).SendKeys("FirstTestAutomation");

            //Enter Price
            IWebElement Price_per_unit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Price_per_unit.SendKeys("50");

            //Click on Save button
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(1000);


        }


        public void EditTM(IWebDriver driver)
        {

            //Navigate to last page
            IWebElement MyRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            MyRecord.Click();

            //int iRowsCount = driver.FindElements(By.XPath("/html/body/..../table/tbody/tr")).Count;

            //Click on Edit button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[1]")).Click();

            //Clear text in Code field
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();

            //Enter the code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("Edited code");

            //Clear the description 
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();

            //Enter the description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Edited description");


            //Clear Price per unit input text
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();

            //Enter value in price per unit text box
            //IWebElement Price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //Price.SendKeys("8995");

            //Click on Save button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            Thread.Sleep(1000);

        }
        public void DeleteTM(IWebDriver driver)

        {
            //Navigate to last page
            IWebElement MyRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            MyRecord.Click();

            Thread.Sleep(1000);

            //Delete the record
            IWebElement Delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            Delete.Click();

            Thread.Sleep(1000);

            //Click on 'OK' button
            CommonDriver.driver.SwitchTo().Alert().Accept();
        }


    }
}