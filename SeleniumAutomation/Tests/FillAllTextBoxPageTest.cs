using NUnit.Framework;
using SeleniumAutomation.Data;
using SeleniumAutomation.Models;
using SeleniumAutomation.PageObject;
using SeleniumAutomation.Setup;

namespace SeleniumAutomation.Tests
{
    [TestFixture]
    public class FillAllTextBoxPageTest : AutomationSetup
    {
        public static DemoQAPage demoQAPage = new DemoQAPage();
        public TextBoxPage textBoxPage = new TextBoxPage();

        [Test, Category("Regression Testing")]
        [TestCaseSource(typeof(FillAllTextBoxPageDataSource), nameof(FillAllTextBoxPageDataSource.FillAllTextBoxPage))]
        public void FillAllTextBoxPage(Users user, TextBoxData validUserData)
        {

            demoQAPage.VerifyThePage();
            demoQAPage.SelectElementsCards();
            textBoxPage.FillTextBoxPage(validUserData);
        }
    }
}
