using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumAutomation.Setup;
using SeleniumAutomation.Enums;
using NUnit.Framework;
using AngleSharp.Dom;

namespace SeleniumAutomation.PageObject
{
    public class DemoQAPage : AutomationSetup
    {
        private readonly DemoQAPageElements demoQAPageElements;

        public DemoQAPage()
        {
            demoQAPageElements = new DemoQAPageElements();
        }
        public void VerifyThePage()
        {
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            var waitCategoryCardsElementResult = driver.FindElement(demoQAPageElements.CategoryCards);
            Assert.IsTrue(waitCategoryCardsElementResult.Displayed, "Verify All the cards were displayed");
        }
        public void SelectElementsCards()
        {
            var waitElementsCardResult = driver.FindElement(demoQAPageElements.ElementsCard);
            Assert.IsTrue(waitElementsCardResult.Displayed, "Verify the elemnts card is displayed");
            waitElementsCardResult.Click();
        }
    }
}
