/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 15/09/21
 */
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace LinkedInTesting_Selenium.Base
{
    [TestFixture]
    public class BaseClass
    {
        //initialization
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
        protected string browser;
        //default constructor
        public BaseClass()
        {

        }
        //parameterized constructor
        public BaseClass(string browser)
        {
            this.browser = browser;
        }
        [SetUp]
        public void Initialize()
        {

            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            try
            {
                switch (browser)
                {

                    case "chrome":
                        //Creating an instance of chrome webdriver
                        driver = new ChromeDriver();
                        break;
                    case "firefox":
                        //Creating an instance of firefox webdriver
                        driver = new FirefoxDriver();
                        break;
                    default:
                        driver = new ChromeDriver();
                        break;
                }

                //print which browser is started
                Console.WriteLine(browser + " Started");
                log.Debug("navigating to url");
                driver.Url = "https://www.linkedin.com/";
                // To maximize browser
                driver.Manage().Window.Maximize();


                log.Info("Exiting setup");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\ScreenShot\" + DateTime.Now.ToString("HHmmss") + ".png");

        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
