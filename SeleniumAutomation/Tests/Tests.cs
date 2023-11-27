using AngleSharp.Dom;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomation.PageObject;
using SeleniumAutomation.Setup;

namespace SeleniumAutomation.Tests
{
    public class Tests : AutomationSetup
    {
        public  static DemoQAPage demoQAPage = new DemoQAPage();
        [Test(Description = "This test is for Navigate to DemoQA page")]
        public void AccessThePage()
        {
            demoQAPage.VerifyThePage();
            demoQAPage.SelectElementsCards();
        }
    }
}
