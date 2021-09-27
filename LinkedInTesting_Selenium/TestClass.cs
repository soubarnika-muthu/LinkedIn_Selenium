/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using AventStack.ExtentReports;
using LinkedInTesting_Selenium.Action;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace LinkedInTesting_Selenium
{
    [TestFixture("chrome")]
    //[TestFixture("firefox")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class PositiveTestCases : Base.BaseClass
    {
        public PositiveTestCases(string browser) : base(browser) { }

        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;
        //checking with valid login credentials
        [Test, Order(0)]
        [Category("Positive TestCases")]
        public void Test_ValidLoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation LinkedIn");

            Action.DoAction.Assert_Titleof_Webpage();
            Action.DoAction.Login_into_LinkedIn(driver);
            Takescreenshot();
            //adding screenshots to reports
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\ScreenShot\Login_SC.png").Build());
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            //Asserting
            String actualUrl = "https://www.linkedin.com/feed/?trk=homepage-basic_signin-form_submit";
            String expectedUrl = driver.Url;
            //Tests whether the specified values are equal.
            Assert.AreEqual(actualUrl, expectedUrl);
        }
        //checking uploading file
        [Test, Order(1)]
        public void Test_UploadingFile()
        {
            Action.DoAction.Upload_Photo();
            //Action.DoAction.Upload_Vedio();
            var checkText = "Post successful.";
            // Tests whether the specified condition is true
            Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[1]/section[1]/ul[1]/li[1]/div[1]/p[1]/span[1]")).Text.Contains(checkText));
        }
        //checking message sending 
        [Test, Order(2)]
        public void Test_Messagesending()
        {
            Action.DoAction.Sending_Message();
            //Tests whether the specified condition is true
            Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[5]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[2]/div[1]/div[1]/div[1]/a[1]/div[1]/dl[1]/dt[1]")).Displayed);
        }
        //checking mail sending
        //[Test, Order(3)]
        //public void Test_SendEmail()
        //{
        //    Email.EmailClass.ReadDataFromExcel();
        //    Email.EmailClass.email_send();
        //}
        [Test, Order(4)]
        public void Test_Invalid_Login()
        {
            Action.DoAction.InvalidPassword(driver);
            string expected = "Please enter your password.";
            string actual = driver.FindElement(By.ClassName("alert-content")).Text;
            Console.WriteLine("Error Message: {0}", actual);
            // Tests whether the specified values are equal.
            Assert.AreEqual(expected, actual);

        }
    }
   
}
