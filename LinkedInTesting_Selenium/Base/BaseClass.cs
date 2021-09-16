using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Base
{
    public class BaseClass
    {
        //initialization
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            //Creating an instance webdriver
            driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/";
            // To maximize browser
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
