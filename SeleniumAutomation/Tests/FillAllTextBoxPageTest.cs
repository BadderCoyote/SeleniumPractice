using NUnit.Framework;
using SeleniumAutomation.Data;
using SeleniumAutomation.Models;
using SeleniumAutomation.PageObject;
using SeleniumAutomation.Setup;

namespace SeleniumAutomation.Tests
{
    public class FillAllTextBoxPageTest : AutomationSetup
    {
        public static DemoQAPage demoQAPage = new DemoQAPage();
        public TextBoxPage textBoxPage = new TextBoxPage();

        [Test(Description = "This test is for fill all text box page")]
        public void FillAllTextBoxPage()
        {
            TextBoxData validFromData = TextBoxDataInstances.ValidData;

            demoQAPage.VerifyThePage();
            demoQAPage.SelectElementsCards();
            textBoxPage.FillTextBoxPage(validFromData);
        }
    }
}
