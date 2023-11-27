using SeleniumAutomation.Setup;
using NUnit.Framework;
using SeleniumAutomation.Enums;
using SeleniumAutomation.Data;
using SeleniumAutomation.Models;
using OpenQA.Selenium;
using SeleniumAutomation.Frame;

namespace SeleniumAutomation.PageObject
{
    public class TextBoxPage : AutomationSetup
    {
        private readonly TextBoxPageElements textBoxPageElements;
        public TextBoxPage() 
        {
            textBoxPageElements = new TextBoxPageElements();
        }


        ElementDefinition buttonDef = new ElementDefinition
        {
            Locator = By.XPath("buttonId")
        };

        public void FillTextBoxPage(TextBoxData textBoxData)
        {
            var texboxButtonResult = driver.FindElement(textBoxPageElements.TextBoxButton);
            Assert.IsTrue(texboxButtonResult.Displayed, "Verify the Text box Button is displayed");
            texboxButtonResult.Click();

            var TextBoxTitleResult = driver.FindElement(textBoxPageElements.TextBoxTitle);
            Assert.IsTrue(TextBoxTitleResult.Displayed, "Verify the Text Box Title was displayed");

            GlobalMetohods.EnterTextAndAssert(textBoxPageElements.FullNameTextBox, textBoxData.FirstName);

            //GlobalMetohods.Click(texboxButtonResult);
            //GlobalMetohods.ClickElement(textBoxPageElements.FullNameTextBox);
            bool isCLicked = GlobalMetohods.ClickBoolElement(textBoxPageElements.FullNameTextBox);
            Assert.IsTrue(isCLicked, "Verify the button was clicked ");


            //Asercion directa
            //texboxButtonResult.Selected.Equals(true);
        }

    }
}
