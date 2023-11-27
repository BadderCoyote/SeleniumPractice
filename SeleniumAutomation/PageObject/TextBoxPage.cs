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

        public void FillTextBoxPage(TextBoxData validUserData)
        {
            var texboxButtonResult = driver.FindElement(textBoxPageElements.TextBoxButton);
            Assert.IsTrue(texboxButtonResult.Displayed, "Verify the Text box Button is displayed");
            texboxButtonResult.Click();
            var TextBoxTitleResult = driver.FindElement(textBoxPageElements.TextBoxTitle);
            Assert.IsTrue(TextBoxTitleResult.Displayed, "Verify the Text Box Title was displayed");
            GlobalMetohods.EnterTextAndAssert(textBoxPageElements.FullNameTextBox, validUserData.FirstName);

            //GlobalMetohods.Click(texboxButtonResult);
            //GlobalMetohods.ClickElement(textBoxPageElements.FullNameTextBox);

            //bool isCLicked = GlobalMetohods.ClickBoolElement(textBoxPageElements.FullNameTextBox);
            //Assert.IsTrue(isCLicked, "Verify the button was clicked ");

            //Asercion directa
            //texboxButtonResult.Selected.Equals(true);

            GlobalMetohods.EnterTextAndAssert(textBoxPageElements.EmailTextBox, validUserData.Email);
            GlobalMetohods.EnterTextAndAssert(textBoxPageElements.CurrentAddressTextBox, validUserData.CurrentAddress);
            GlobalMetohods.EnterTextAndAssert(textBoxPageElements.PermanentAddressTextBox, validUserData.PermanentAddress);
            bool isCLicked = GlobalMetohods.ClickBoolElement(textBoxPageElements.SubmitButton);
            Assert.IsTrue(isCLicked, "Verify the Submit button was clicked ");
            string getDisplayedNameTextResult = GlobalMetohods.GetTextAfetrColon(textBoxPageElements.DisplayedNameText);
            Assert.AreEqual(validUserData.FirstName, getDisplayedNameTextResult, "Verify the displayed name is correct");
            string getDisplayedEmailTextResult = GlobalMetohods.GetTextAfetrColon(textBoxPageElements.DisplayedEmailText);
            Assert.AreEqual(validUserData.Email, getDisplayedEmailTextResult, "Verify the displayed email is correct");
            string getDisplayedCurrentAddressTextResult = GlobalMetohods.GetTextAfetrColon(textBoxPageElements.DisplayedCurrentAddressText);
            Assert.AreEqual(validUserData.CurrentAddress, getDisplayedCurrentAddressTextResult, "Verify the displayed current address is correct");
            string getDisplayedPermanentAddressTextResult = GlobalMetohods.GetTextAfetrColon(textBoxPageElements.DisplayedPermanentAddressText);
            Assert.AreEqual(validUserData.PermanentAddress, getDisplayedPermanentAddressTextResult, "Verify the displayed permanent address is correct");
        }

    }
}
