using LinkedInTesting_Selenium.Operations;
using LinkedInTesting_Selenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Action
{
    public class DoAction : Base.BaseClass
    {
        public static LoginPage login;

        //Method to check title of webpage
          public static void Assert_Titleof_Webpage()
          {
              string title1 = "LinkedIn: Log In or Sign Up";
              string title = driver.Title;
              Assert.AreEqual(title1, title);
          }


        //Method to enter login credentials into webpage
        public static void Login_into_LinkedIn()
        {
            //specifying file path
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
            Debug.WriteLine("**");
            //Reads data from excel file and enters data into webpage using sendkeys method
            driver.FindElement(By.Name("session_key")).SendKeys(ExcelOperations.ReadData(1, "email"));
            //process waits for sometime
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("session_password")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //using the click function 
            driver.FindElement(By.ClassName("sign-in-form__submit-button")).Click();
            System.Threading.Thread.Sleep(10000);

        }
        public static void Signup_LinkedIn()
        {
            //specifying file path
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Signup_TestData.xlsx");
            Debug.WriteLine("**");
            driver.FindElement(By.ClassName("nav__button-tertiary")).Click();
            //Reads data from excel file and enters data into webpage using sendkeys method
            driver.FindElement(By.Name("email-or-phone")).SendKeys(ExcelOperations.ReadData(1, "email"));
            //process waits for sometime
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("password")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //using the click function 
            driver.FindElement(By.Id("join-form-submit")).Click();
            System.Threading.Thread.Sleep(10000);

        }
    }
}
