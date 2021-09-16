using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [FindsBy(How = How.Name, Using = "email-or-phone")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "join-form-submit")]
        [CacheLookup]
        public IWebElement loginbt;
    }
}
