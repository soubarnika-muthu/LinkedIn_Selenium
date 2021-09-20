/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace LinkedInTesting_Selenium.Pages
{
    public class LoginPage : Base.BaseClass
    {
        //initializing pagefactory method
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.Name, Using = "session_key")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "session_password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.ClassName, Using = "sign-in-form__submit-button")]
        [CacheLookup]
        public IWebElement loginbt; 


       
    }
}
