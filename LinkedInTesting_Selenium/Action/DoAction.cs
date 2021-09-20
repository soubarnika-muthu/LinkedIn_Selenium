using LinkedInTesting_Selenium.Operations;
using LinkedInTesting_Selenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Diagnostics;


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
        public static void Login_into_LinkedIn(IWebDriver driver)
        {
            login = new LoginPage(driver);
            //specifying file path
            Takescreenshot();
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
            Debug.WriteLine("**");
            //Reads data from excel file and enters data into webpage using sendkeys method
            login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);

            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //using the click function 
            login.loginbt.Click();
            System.Threading.Thread.Sleep(2000);

            KeyboardActions.PerformKeyboardActions();
        }

        public static void Signup_LinkedIn()
        {
            //specifying file path
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Signup_TestData.xlsx");
            Debug.WriteLine("**");
            driver.FindElement(By.ClassName("nav__button-tertiary")).Click();
            System.Threading.Thread.Sleep(2000);
            //Reads data from excel file and enters data into webpage using sendkeys method
            driver.FindElement(By.Name("email-or-phone")).SendKeys(ExcelOperations.ReadData(1, "phone"));
            //process waits for sometime
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("password")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //using the click function 
            driver.FindElement(By.Id("join-form-submit")).Click();
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Name("first-name")).SendKeys(ExcelOperations.ReadData(1, "firstname"));
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Name("last-name")).SendKeys(ExcelOperations.ReadData(1, "lastname"));
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("join-form-submit")).Click();
            System.Threading.Thread.Sleep(30000);

            //// IWebElement country = ;
            // SelectElement country = new SelectElement(driver.FindElement(By.Id("select-register-phone-country")));
            // country.SelectByValue("us");
            ////driver.SwitchTo().Frame(1);
            //driver.FindElement(By.Id("register-verification-phone-number")).SendKeys(ExcelOperations.ReadData(1, "phonenumber"));
            //System.Threading.Thread.Sleep(2000);

            //driver.FindElement(By.Id("register-phone-submit-button")).Click();
            //System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("register-phone-submit-button")).Click();
            System.Threading.Thread.Sleep(10000);

            //IWebElement = //
            //IWebElement city = driver.FindElement(By.Id("typeahead-input-for-city-district"));
            //city.SendKeys(ExcelOperations.ReadData(1, "city"));
            //System.Threading.Thread.Sleep(2000);
            //city.SendKeys(Keys.ArrowDown);
            //System.Threading.Thread.Sleep(2000);
            //city.SendKeys(Keys.Enter);
            //System.Threading.Thread.Sleep(2000);
        }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\ScreenShot\"+ DateTime.Now.ToString("HHmmss") + ".png");
        
        }


    }
}
