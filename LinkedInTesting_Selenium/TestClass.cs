/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using AventStack.ExtentReports;
using LinkedInTesting_Selenium.Action;
using NUnit.Framework;

namespace LinkedInTesting_Selenium
{
    public class Tests : Base.BaseClass
    {
        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;
        [Test]
        public void Test__LoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation LinkedIn");

            Action.DoAction.Assert_Titleof_Webpage();
            Action.DoAction.Login_into_LinkedIn(driver);

            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
        }
        //[Test]
        //public void Signup_Test()
        //{
        //    Action.DoAction.Signup_LinkedIn();
        //}
    }
}