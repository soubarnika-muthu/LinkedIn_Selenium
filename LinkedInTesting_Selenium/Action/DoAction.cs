/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using AutoItX3Lib;
using LinkedInTesting_Selenium.Operations;
using LinkedInTesting_Selenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Diagnostics;


namespace LinkedInTesting_Selenium.Action
{
    [TestFixture]
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
            try
            {
                login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Login_TestData.xlsx");
                Debug.WriteLine("**");
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
                System.Threading.Thread.Sleep(2000);

                //using the click function 
                login.loginbt.Click();
                System.Threading.Thread.Sleep(3000);
                Takescreenshot();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
        public static void Logout_from_LinkedIn(IWebDriver driver)
        {

            //Login_into_LinkedIn(driver);
            Logout logout = new Logout(driver);
            logout.menu.Click();
            System.Threading.Thread.Sleep(4000);
            //using the click function 
            logout.logoutbt.Click();
            System.Threading.Thread.Sleep(4000);

        }
       
        public static void Upload_Photo()
        {
            try
            {
                //calling login method
                Login_into_LinkedIn(driver);
                UploadPhoto uploadphoto = new UploadPhoto(driver);
                uploadphoto.post.Click();
                System.Threading.Thread.Sleep(3000);
                uploadphoto.photo.Click();
                System.Threading.Thread.Sleep(3000);
                //creating object of AutoIt class
                AutoItX3 autoIt = new AutoItX3();
                //Activating file upload window
                autoIt.WinActivate("Open");
                System.Threading.Thread.Sleep(2000);
                //Sending the file path 
                autoIt.Send(@"C:\Users\soubarnika.v\Downloads\Selenium.jfif");
                System.Threading.Thread.Sleep(2000);
                autoIt.Send("{ENTER}");
                System.Threading.Thread.Sleep(3000);

                uploadphoto.donebt.Click();
                System.Threading.Thread.Sleep(3000);

                uploadphoto.comments.SendKeys("Automation Testing using selenium");
                System.Threading.Thread.Sleep(3000);
                Takescreenshot();
                uploadphoto.postbt.Click();
                System.Threading.Thread.Sleep(6000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Upload_Vedio()
        {
            try
            {
                //calling login method
                Login_into_LinkedIn(driver);
                UploadVedio uploadVedio = new UploadVedio(driver);
                uploadVedio.v_post.Click();
                System.Threading.Thread.Sleep(3000);
                uploadVedio.vedio.Click();
                System.Threading.Thread.Sleep(3000);
                AutoItX3 autoIt = new AutoItX3();
                //Activating file upload window
                autoIt.WinActivate("Open");
                System.Threading.Thread.Sleep(2000);
                //Sending the file path 
                autoIt.Send(@"C:\Users\soubarnika.v\Downloads\Motivational-Video.mp4");
                System.Threading.Thread.Sleep(2000);
                autoIt.Send("{ENTER}");
                System.Threading.Thread.Sleep(3000);

                uploadVedio.v_donebt.Click();
                System.Threading.Thread.Sleep(3000);

                uploadVedio.v_comments.SendKeys("motivational vedio");
                System.Threading.Thread.Sleep(3000);

                uploadVedio.v_postbt.Click();
                System.Threading.Thread.Sleep(40000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Sending_Message()
        {

            try
            {
                //calling login method
                Login_into_LinkedIn(driver);
                //creating instance of messaging class
                Messaging message = new Messaging(driver);
                message.msg.Click();
                System.Threading.Thread.Sleep(3000);
                //message.penoption.Click();
                //System.Threading.Thread.Sleep(3000);
                //message.penoption.Click();
                //System.Threading.Thread.Sleep(3000);
                //message.searchterm.Click();
                //System.Threading.Thread.Sleep(3000);
                //message.searchterm.SendKeys("Soubarnika Muthu");
                //System.Threading.Thread.Sleep(3000);
                //message.searchterm.SendKeys(Keys.ArrowDown);
                //System.Threading.Thread.Sleep(3000);
                //message.searchterm.SendKeys(Keys.Enter);
                //System.Threading.Thread.Sleep(3000);
                //message.write.Click();
                System.Threading.Thread.Sleep(3000);
                message.write.SendKeys("Hii soubarnika");
                System.Threading.Thread.Sleep(3000);
                message.sendbt.Click();
                System.Threading.Thread.Sleep(3000);

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void PerformSearch()
        {
            try
            {
                Login_into_LinkedIn(driver);
                LoginPage search = new LoginPage(driver);
                search.searchbar.SendKeys("TVS Next");
                System.Threading.Thread.Sleep(2000);
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(2000);
               search.searchbar.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void EndtoEnd_Testing()
        {
            try
            {
                Login_into_LinkedIn(driver);
                Upload_Photo();
                Logout_from_LinkedIn(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Signup_LinkedIn()
        {
            try
            {
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\Signup_TestData.xlsx");
                Debug.WriteLine("**");

                SignupPage signup = new SignupPage(driver);

                signup.join_now.Click();
                System.Threading.Thread.Sleep(2000);

                //Reads data from excel file and enters data into webpage using sendkeys method
                signup.email.SendKeys(ExcelOperations.ReadData(1, "phone"));
                //process waits for sometime
                System.Threading.Thread.Sleep(2000);

                signup.password.SendKeys(ExcelOperations.ReadData(1, "password"));
                System.Threading.Thread.Sleep(2000);

                signup.registerbt.Click();
                System.Threading.Thread.Sleep(2000);

                signup.firstName.SendKeys(ExcelOperations.ReadData(1, "firstname"));
                System.Threading.Thread.Sleep(2000);

                signup.lastName.SendKeys(ExcelOperations.ReadData(1, "lastname"));
                System.Threading.Thread.Sleep(2000);

                signup.continuebt1.Click();
                System.Threading.Thread.Sleep(40000);

                driver.Navigate().Back();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
