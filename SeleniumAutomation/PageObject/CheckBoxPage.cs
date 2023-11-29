using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomation.Enums;
using SeleniumAutomation.Models;
using SeleniumAutomation.Setup;


namespace SeleniumAutomation.PageObject
{
    public class CheckBoxPage : AutomationSetup
    {
        private readonly CheckBoxPageElements checkBoxPageElements;
        private readonly List<CheckBoxDocuments> checkBoxWorkspaceDocumentList;
        public CheckBoxPage()
        {
            checkBoxPageElements = new CheckBoxPageElements();
            checkBoxWorkspaceDocumentList = new List<CheckBoxDocuments>
            {
                CheckBoxDocuments.React,
                CheckBoxDocuments.Angular,
                CheckBoxDocuments.Veu,
                CheckBoxDocuments.Public,
                CheckBoxDocuments.Private,
                CheckBoxDocuments.Classified,
                CheckBoxDocuments.General,
            };
        }
        public void CheckBoxPageTest(CheckBoxOptions checkBoxOptions, CheckBoxSubsection checkBoxSubsection, CheckBoxDocuments checkBoxDocuments)
        {
            var checkBoxButtonResult = driver.FindElement(checkBoxPageElements.CheckBoxButton);
            Assert.IsTrue(checkBoxButtonResult.Displayed, "Verify the Check Box Button is displayed");
            checkBoxButtonResult.Click();
            var checkBoxTitleResult = driver.FindElement(checkBoxPageElements.CheckBoxTitle);
            Assert.IsTrue(checkBoxTitleResult.Displayed, "Verify the Check Box Title was displayed");
            ExpandButtons(checkBoxPageElements.ExpandButtonDynamic);

            var optionSelectedActual = checkBoxDocuments;
            string optionSelected = "";
            if (optionSelectedActual != null)
            {
                ExpandButtons(checkBoxPageElements.ExpandButtonDynamic);
                optionSelected = optionSelectedActual switch
                {
                    CheckBoxDocuments.React => "React",
                    CheckBoxDocuments.Angular => "Angular",
                    CheckBoxDocuments.Veu => "Veu",
                    CheckBoxDocuments.Public => "Public",
                    CheckBoxDocuments.Private => "Private",
                    CheckBoxDocuments.Classified => "Classified",
                    CheckBoxDocuments.General => "General"
                };
            }
            else
            {
                optionSelected = checkBoxSubsection switch
                {
                    CheckBoxSubsection.Notes => "Notes",
                    CheckBoxSubsection.Commands => "Commands",
                    CheckBoxSubsection.WordFile => "Word File.doc",
                    CheckBoxSubsection.ExcelFile => "Excel File.doc",
                };
            }
            string xPathDynamic = "//span[@class='rct-title'][text()='{0}']";
            By dynamicElement = GlobalMetohods.GetDynamicXPath(xPathDynamic, optionSelected);
            var waitFordynamicElementResult = driver.FindElement(dynamicElement);
            Assert.IsTrue(waitFordynamicElementResult.Displayed, "Verify the Dynamic Element was displayed");
            bool clickDynamicElementResult = GlobalMetohods.ClickBoolElement(dynamicElement);
            Assert.IsTrue(clickDynamicElementResult, "Verify the Dynamic Element was clicked");
        }

        public void ExpandButtons(By element)
        {
            var waitExpandButtonDynamicResult = driver.FindElement(element);
            Assert.IsTrue(waitExpandButtonDynamicResult.Displayed, "Verify the Expand Button Dynamic was displayed");
            GlobalMetohods.ClickElement(element);

            var waitForExpandButtonDynamICResult = driver.FindElement(element);
            Assert.IsTrue(waitForExpandButtonDynamICResult.Displayed, "Verify the Expand Button Dynamic was displayed");
            IList<IWebElement> findAllExpandButtons = driver.FindElements(element);
            foreach (var expandButtonResult in findAllExpandButtons)
            {
                expandButtonResult.Click();
            }
        }
    }
}
