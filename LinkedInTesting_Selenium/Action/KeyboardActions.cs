using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Action
{
  public  class KeyboardActions : Base.BaseClass
    {
        public static void PerformKeyboardActions()
        {
           
            //finds the element using Xpath
            IWebElement myelement = driver.FindElement(By.XPath("//header/div[1]/div[1]/div[1]/div[1]/input[1]"));
            myelement.SendKeys("tvs");
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.ArrowDown);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
