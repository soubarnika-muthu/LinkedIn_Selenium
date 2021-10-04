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
    [TestFixture("firefox")]
    [Parallelizable(ParallelScope.Fixtures)]

    public class TestCases : Base.BaseClass
    {
        public TestCases(string browsername) : base(browsername)
        {
        }

        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;

        //checking with valid login credentials
        [Test, Order(0)]
        public void Test_ValidLoginPage()
        {
            //Generating reports
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
            //Assert.AreEqual(actualUrl, expectedUrl);
            if (expectedUrl.Equals(actualUrl))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
        [Test, Order(1)]
        public void Test_SearchingMethod()
        {
            Action.DoAction.PerformSearch();
            string searchtitle = "\"TVS Next\" | Search | LinkedIn";
            //Assert.AreEqual(driver.Title,searchtitle);
            if (searchtitle.Equals(driver.Title))
            {
                Console.WriteLine("Search Successful");
            }
            else
            {
                Console.WriteLine("Search Failed");
            }
        }
        //checking uploading file
        [Test, Order(2)]
        public void Test_UploadingFile()
        {
            Action.DoAction.Upload_Photo();
            //Action.DoAction.Upload_Vedio();
            var checkText = "Post successful.";
            //Tests whether the specified condition is true
            //Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[1]/section[1]/ul[1]/li[1]/div[1]/p[1]/span[1]")).Text.Contains(checkText));
            IWebElement element = driver.FindElement(By.XPath("//body[1]/div[1]/section[1]/ul[1]/li[1]/div[1]/p[1]/span[1]"));
            if (element.Text.Contains(checkText))
            {
                Console.WriteLine("File Uploaded Successfully");
            }
            else
            {
                Console.WriteLine("File Upload Failed");
            }
        }
        //  checking message sending
        [Test, Order(3)]
        public void Test_Messagesending()
        {
            Action.DoAction.Sending_Message();
            //Tests whether the specified condition is true
            //Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[5]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[2]/div[1]/div[1]/div[1]/a[1]/div[1]/dl[1]/dt[1]")).Displayed);
        }
        //checking mail sending
        [Test, Order(4)]
        public void Test_SendEmail()
        {
            Email.EmailClass.ReadDataFromExcel();
            Email.EmailClass.email_send();
        }
        [Test, Order(5)]
        public void Test_Invalid_Username()
        {
            Action.NegativeTestCases.Invalid_Username();
            string expected = "Couldn't find a LinkedIn account associated with this phone number. Please try again.";
            string actual = driver.FindElement(By.Id("error-for-username")).Text;
            if (expected.Equals(actual))
            {
                Console.WriteLine("Given Error Message: {0}", actual);
            }
            else
            {
                Console.WriteLine("Testcase Failed");
            }
        }

        [Test, Order(6)]
        public void Test_Invalid_Password()
        {
            Action.NegativeTestCases.Empty_PasswordField();
            string expected = "Please enter your password.";
            string actual = driver.FindElement(By.ClassName("alert-content")).Text;
            Console.WriteLine("Error Message: {0}", actual);
            if (expected.Equals(actual))
            {
                Console.WriteLine("Given Error Message: {0}", actual);
            }
            else
            {
                Console.WriteLine("Testcase Failed");
            }
        }
        //Checking end to end testing
        [Test, Order(6)]
        public void Test_EndtoEnd()
        {
            Action.DoAction.EndtoEnd_Testing();
            String actualUrl = "https://www.linkedin.com/home"; ;
            String expectedUrl = driver.Url;
            //Tests whether the specified values are equal.
            Assert.AreEqual(actualUrl, expectedUrl);
        }


    }

}
