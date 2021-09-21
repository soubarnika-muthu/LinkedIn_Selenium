using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Pages
{
    class UploadPhoto:Base.BaseClass
    {
        public UploadPhoto(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Upload a photo

        [FindsBy(How = How.XPath, Using = "//*[@id='ember44']")]
        [CacheLookup]
        public IWebElement post;


        //[FindsBy(How = How.XPath, Using = "//body/div[6]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/main[1]/div[1]/div[1]/div[2]/span[1]/button[1]/span[1]")]
        //[CacheLookup]
        //public IWebElement photo;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/span[1]/button[1]")]
        [CacheLookup]
        public IWebElement photo;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/button[1]/span[1]")]
        [CacheLookup]
        public IWebElement donebt;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/p[1]")]
        [CacheLookup]
        public IWebElement comments;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[3]/button[1]/span[1]")]
        [CacheLookup]
        public IWebElement postbt;

     

    }
}
