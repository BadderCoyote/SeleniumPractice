using NUnit.Framework;
using SeleniumAutomation.Setup;
using SeleniumAutomation.Data;
using SeleniumAutomation.Models;
using SeleniumAutomation.PageObject;

namespace SeleniumAutomation.Tests
{
    [TestFixture]
    public  class CheckBoxTest : AutomationSetup
    {
        public static DemoQAPage demoQAPage = new DemoQAPage();
        public static CheckBoxPage checkBoxPage = new CheckBoxPage();
        [TestCaseSource(typeof(CheckBoxTestDataSource), nameof(CheckBoxTestDataSource.CheckBoxTest))]
        [Test, Category("Regression Testing")]

        public void CheckBoxPageTest(CheckBoxOptions checkBoxOptions, CheckBoxSubsection checkBoxSubsection , CheckBoxDocuments checkBoxDocuments)
        {
            demoQAPage.VerifyThePage();
            demoQAPage.SelectElementsCards();
            checkBoxPage.CheckBoxPageTest(checkBoxOptions, checkBoxSubsection, checkBoxDocuments);
        }
    }
}
