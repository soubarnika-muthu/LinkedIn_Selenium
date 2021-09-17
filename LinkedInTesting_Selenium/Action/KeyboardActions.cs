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
            //finds the element using id
            IWebElement myelement = driver.FindElement(By.Name("session_password"));
            //myelement.SendKeys(Keys.Control + "a");

            myelement.SendKeys(Keys.Home);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.End);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.ArrowDown);
            // Enter text  and perform keyboard action "Enter"
            myelement.SendKeys("9629522931");
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(2000);
        }
    }
}
