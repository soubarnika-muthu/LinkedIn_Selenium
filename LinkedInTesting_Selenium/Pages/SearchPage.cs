using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LinkedInTesting_Selenium.Pages
{
    public class SearchPage : Base.BaseClass
    {
        //initializing pagefactory method
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.XPath, Using = "//header/div[1]/div[1]/div[1]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement searchbar;

        [FindsBy(How = How.Id, Using = "session_password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.ClassName, Using = "sign-in-form__submit-button")]
        [CacheLookup]
        public IWebElement loginbt;
    }
}
