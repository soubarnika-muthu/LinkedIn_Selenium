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
   // [Parallelizable(ParallelScope.Fixtures)]
    public class Tests : Base.BaseClass
    {
        public Tests(string browser) : base(browser) { }
        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;

        [Test, Order(0)]
        public void Test__LoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation LinkedIn");

            Action.DoAction.Assert_Titleof_Webpage();
            Action.DoAction.Login_into_LinkedIn(driver);
            Takescreenshot();
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\ScreenShot\Login_SC.png").Build());
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            String actualUrl = "https://www.linkedin.com/feed/?trk=homepage-basic_signin-form_submit";
            String expectedUrl = driver.Url;
            Assert.AreEqual(actualUrl, expectedUrl);
        }
        [Test, Order(1)]
        public void Test_UploadingFile()
        {
            Action.DoAction.Upload_Photo();

            //Action.DoAction.Upload_Vedio();
            var checkText = "Post successful.";
            Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[1]/section[1]/ul[1]/li[1]/div[1]/p[1]/span[1]")).Text.Contains(checkText));
        }
        [Test, Order(2)]
        public void Test_SendEmail()
        {
            Email.EmailClass.ReadDataFromExcel();
            Email.EmailClass.email_send();
        }


    }
}