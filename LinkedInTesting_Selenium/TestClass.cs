/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using AventStack.ExtentReports;
using LinkedInTesting_Selenium.Action;
using NUnit.Framework;
using System;

namespace LinkedInTesting_Selenium
{
    public class Tests : Base.BaseClass
    {
        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;
        /*  [Test]
          public void Test__LoginPage()
          {
              test = reports.CreateTest("Tests");
              test.Log(Status.Info, "Automation LinkedIn");
              String actualUrl = "https://www.linkedin.com/feed/?trk=homepage-basic_signin-form_submit";
              Action.DoAction.Assert_Titleof_Webpage();
              Action.DoAction.Login_into_LinkedIn(driver);
              String expectedUrl = driver.Url;
              if (actualUrl.Equals(expectedUrl))
              {
                  Console.WriteLine("Test passed login successful");
              }
              else
              {
                  Console.WriteLine("Test failed" + driver.Url);
              }
              //test.Log(Status.Pass, "Test Passes");
              reports.Flush();
          }*/
        //[Test]
        //public void Test_PhotoUploading()
        //{
        //    Action.DoAction.Upload_Photo();

        //}

        [Test]
        public void Test_VedioUploading()
        {
            Action.DoAction.Upload_Vedio();
        }
    }
}