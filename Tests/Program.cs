
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Helpers;
using Test.Pages;


namespace Test
{
    class Program
    {
        static void Main(string[] args)

        {
            CommonDriver.driver = new ChromeDriver();

            LoginPage LoginstepsObj = new LoginPage();
            LoginstepsObj.Loginsteps(CommonDriver.driver);

            //Steps to Navigate to TMpage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);

            //Steps to create a TM
            TMpage tmObj = new TMpage();
            tmObj.AddTM(CommonDriver.driver);

            //Steps to EditTM 
            TMpage tmObj1 = new TMpage();
            tmObj1.EditTM(CommonDriver.driver);
        }

    }
}
    

