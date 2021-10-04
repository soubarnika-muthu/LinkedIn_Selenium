/*Project = Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace LinkedInTesting_Selenium.Pages
{
    public class SignupPage : Base.BaseClass
    {
        //initializing pagefactory method
        public SignupPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.ClassName, Using = "nav__button-tertiary")]
        [CacheLookup]
        public IWebElement join_now;

        [FindsBy(How = How.Name, Using = "email-or-phone")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "join-form-submit")]
        [CacheLookup]
        public IWebElement registerbt;

        [FindsBy(How = How.XPath, Using = "//*[text()='Create New Account']")]
        [CacheLookup]
        public IWebElement CreateButton;

        [FindsBy(How = How.Name, Using = "first-name")]
        [CacheLookup]
        public IWebElement firstName;

        [FindsBy(How = How.Name, Using = "last-name")]
        [CacheLookup]
        public IWebElement lastName;

        [FindsBy(How = How.Id, Using = "join-form-submit")]
        [CacheLookup]
        public IWebElement continuebt1;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/footer[1]/button[1]")]
        [CacheLookup]
        public IWebElement continuebt2;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement emp_role;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[2]/div[1]/div[2]/div[1]/select[1]")]
        [CacheLookup]
        public IWebElement emp_type;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[2]/div[1]/div[3]/div[1]/div[1]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement company_name;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/section[2]/div[1]/footer[1]/button[2]")]
        [CacheLookup]
        public IWebElement continuebt3;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[2]/button[2]/span[1]")]
        [CacheLookup]
        public IWebElement not_nowbt;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/section[1]/footer[1]/span[1]/button[1]/span[1]")]
        [CacheLookup]
        public IWebElement skip1;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/button[1]/span[1]")]
        [CacheLookup]
        public IWebElement skip2;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[2]/button[3]/span[1]")]
        [CacheLookup]
        public IWebElement skip3;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[2]/section[1]/div[3]/button[2]/span[1]")]
        [CacheLookup]
        public IWebElement skip4;

      

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[2]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/footer[1]/div[1]/button[1]")]
        [CacheLookup]
        public IWebElement finish;



    }
}
