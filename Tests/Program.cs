
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Helpers;
using Test.Pages;


namespace Test
{
    [TestFixture]
    class Program
    {
        [SetUp]
        public void LoginTest()
        {
            CommonDriver.driver = new ChromeDriver();

            LoginPage LoginstepsObj = new LoginPage();
            LoginstepsObj.Loginsteps(CommonDriver.driver);

            //Steps to Navigate to TMpage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);
        }

        [Test]
        public void AddTMTest()
        {
            //Steps to create a TM
            TMpage tmObj = new TMpage();
            tmObj.AddTM(CommonDriver.driver);
        }

        [Test]
        public void EditTMTest()
        {
            //Steps to EditTM 
            TMpage tmObj1 = new TMpage();
            tmObj1.EditTM(CommonDriver.driver);
        }

        [Test]
        public void DeleteTMTest()
        {

            //Steps to DeleteTM 
            TMpage tmObj2 = new TMpage();
            tmObj2.DeleteTM(CommonDriver.driver);
        }

        [TearDown]
        public void FlushTest()
        {
            //Close driver
            CommonDriver.driver.Close();
        }

        static void Main(string[] args)

        {
            

           

           

           

        }

    }
}
    

