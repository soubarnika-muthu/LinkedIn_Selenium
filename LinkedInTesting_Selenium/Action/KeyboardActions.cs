/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using LinkedInTesting_Selenium.Pages;
using OpenQA.Selenium;
using System;

namespace LinkedInTesting_Selenium.Action
{
    public class KeyboardActions : Base.BaseClass
    {
        public static void PerformSearch()
        {
            try
            {
                SearchPage search = new SearchPage(driver);
                search.searchbar.SendKeys("TVS ");
                System.Threading.Thread.Sleep(2000);
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(1000);
                Takescreenshot();
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(1000);
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(1000);
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(1000);
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(2000);
                search.searchbar.SendKeys(Keys.Enter);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
