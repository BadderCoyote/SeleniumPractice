using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomation.Frame;
using SeleniumAutomation.Setup;

namespace SeleniumAutomation.PageObject
{
    public class GlobalMetohods : AutomationSetup
    {
        public static void EnterTextAndAssert(By element, string textToEnter)
        {
            var textbox = driver.FindElement(element);
            textbox.SendKeys(textToEnter);

            Assert.AreEqual(textToEnter, textbox.GetAttribute("value"), "Verify that the entered text is correct");
        }
        public static void Click(IWebElement element)
        { 
            element.Click();
        }
        public static void ClickElement(By elment)
        {
            driver.FindElement(elment).Click();
        }
        public static bool ClickBoolElement(By element)
        {
            try
            {
                IWebElement elementResult = driver.FindElement(element);
                elementResult.Click();
                return true;
            }
            catch (NoSuchElementException) 
            {
                return false;
            }
        }
        public static string GetTextAfetrColon(By element)
        {
            try
            {
                IWebElement elementResult = driver.FindElement(element);
                string fullText = elementResult.Text;
                string[] parts = fullText.Split(':');
                string splitTextResult = parts[1].Trim();
                return splitTextResult;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}
