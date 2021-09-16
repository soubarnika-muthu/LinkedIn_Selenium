using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [FindsBy(How = How.XPath, Using = "//*[@id='main - content']/section[1]/div[2]/form/button")]
        [CacheLookup]
        public IWebElement loginbt;
    }
}
