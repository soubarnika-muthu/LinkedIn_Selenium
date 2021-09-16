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
           
        }
        [Test]
        public void Signup_Test()
        {
            Action.DoAction.Signup_LinkedIn();
        }


    }
}