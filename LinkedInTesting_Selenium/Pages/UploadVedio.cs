using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Pages
{
    class UploadVedio : Base.BaseClass
    {
        public UploadVedio(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Upload a photo

        [FindsBy(How = How.XPath, Using = "//*[@id='ember43']")]
        [CacheLookup]
        public IWebElement v_post;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/span[2]/button[1]/li-icon[1]")]
        [CacheLookup]
        public IWebElement vedio;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/button[2]/span[1]")]
        [CacheLookup]
        public IWebElement v_donebt;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/p[1]")]
        [CacheLookup]
        public IWebElement v_comments;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[3]/button[1]/span[1]")]
        [CacheLookup]
        public IWebElement v_postbt;
    }
}
