/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace LinkedInTesting_Selenium.Pages
{
    public class Logout : Base.BaseClass
    {
        //initializing pagefactory method
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        //login page
        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/header[1]/div[1]/nav[1]/ul[1]/li[6]/div[1]/button[1]")]
        [CacheLookup]
        public IWebElement menu;

        [FindsBy(How = How.PartialLinkText, Using = "Sign Out")]

        [CacheLookup]
        public IWebElement logoutbt;

    }



}

