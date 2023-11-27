using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumAutomation.Setup
{
    public class AutomationSetup
    {
       public static IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void CloseVrowser()
        {
            driver.Quit();
        }
    }
}
    