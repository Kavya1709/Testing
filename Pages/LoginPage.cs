using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Test.Pages
{
    class LoginPage
    {
        //steps to login page
        public void Loginsteps(IWebDriver driver)
        {

            //enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //maximise the window
            driver.Manage().Window.Maximize();

            //enter the username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("Hari");

            //enter the password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //click on login
            IWebElement Submit = driver.FindElement(By.XPath(".//*[@id='loginForm']/form/div[3]/input[1]"));
            Submit.Click();

            //check if user has logged in successfully
            IWebElement element = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (element.Text == "Hello hari!")
            {
                Console.WriteLine("User logged in successfully");
            }
            else
            {
                Console.WriteLine("Test failed! User login unsuccessful");
            }
        }
    }
}
