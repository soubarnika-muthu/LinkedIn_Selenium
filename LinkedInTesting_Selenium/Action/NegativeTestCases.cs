/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */

using LinkedInTesting_Selenium.Operations;
using LinkedInTesting_Selenium.Pages;
using OpenQA.Selenium;
using System;
using System.Diagnostics;

namespace LinkedInTesting_Selenium.Action
{
    public class NegativeTestCases : Base.BaseClass
    {
        public static LoginPage login;

        public static void Invalid_Username()
        {
            try
            {
                login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
                Debug.WriteLine("**");
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(4, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(4, "password"));
                System.Threading.Thread.Sleep(2000);

                //using the click function 
                login.loginbt.Click();
                System.Threading.Thread.Sleep(15000);


            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
        public static void Empty_PasswordField()
        {
            try
            {
                login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
                Debug.WriteLine("**");
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(2, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(2, "password"));
                System.Threading.Thread.Sleep(2000);

                //using the click function 
                login.loginbt.Click();
                System.Threading.Thread.Sleep(15000);


            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
        public static void Invalid_Password(IWebDriver driver)
        {
            try
            {
                login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
                Debug.WriteLine("**");
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(3, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(3, "password"));
                System.Threading.Thread.Sleep(2000);

                //using the click function 
                login.loginbt.Click();
                System.Threading.Thread.Sleep(15000);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
