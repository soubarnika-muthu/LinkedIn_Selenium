/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using NUnit.Framework;

namespace LinkedInTesting_Selenium
{
    public class Tests : Base.BaseClass
    {

        [Test]
          public void Test__LoginPage()
          {

              Action.DoAction.Assert_Titleof_Webpage();
            // Action.DoAction.Login_into_LinkedIn();
            Action.DoAction.ReadingDataFromFile(driver);


          }
         /* [Test]
          public void Test_Keyboardactions()
          {
              Action.DoAction.PerformKeyboardActions();
          }*/
      /*  [Test]
        public void Signup_Test()
        {
              Action.DoAction.Signup_LinkedIn();
        }*/


    }
}