using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Pages
{
    public class Messaging : Base.BaseClass
    {
        //initializing pagefactory method
        public Messaging(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/header[1]/div[1]/nav[1]/ul[1]/li[4]/a[1]/span[1]")]
        [CacheLookup]
        public IWebElement msg;

       

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[1]/div[1]/div[1]/a[1]/li-icon[1]")]
        [CacheLookup]
        public IWebElement penoption;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[2]/div[1]/div[2]/section[1]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement searchterm;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/p[1]")]
        [CacheLookup]
        public IWebElement write;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[6]/div[3]/div[2]/div[1]/div[1]/main[1]/div[1]/section[2]/div[1]/form[1]/footer[1]/div[2]/div[1]/button[1]")]
        [CacheLookup]
        public IWebElement sendbt;


    }
}