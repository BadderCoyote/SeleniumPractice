using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Enums
{
    public class CheckBoxPageElements
    {
        public By CheckBoxButton { get; set; } = By.XPath("//span[@class='text'][contains(text(),'Check Box')]");
        public By CheckBoxTitle { get; set; } = By.XPath("//div[@class='main-header'][contains(text(),'Check Box')]");

        //public By ExpandButtonDynamic { get; set; } = By.XPath("//li[contains(@class, 'rct-node') and contains(@class, 'rct-node-parent') " +
          //  "and (contains(@class, 'rct-node-collapsed') or contains(@class, 'rct-node-expanded'))]");
        public By ExpandButtonDynamic { get; set; } = By.XPath("//li[@class='rct-node rct-node-parent rct-node-collapsed']/span/button");
        


        public By DesktopCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Desktop')]");
        public By DocumentsCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Documents')]");
        public By DownloadsCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Downloads')]");
        public By NotesCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Notes')]");
        public By CommandsCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Commands')]");
        public By WorkspaceCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Workspace')]");
        public By OfficeCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Office')]");
        public By WordFileCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Word File')]");
        public By ExcelFileCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Excel File')]");
        public By ReactCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'React')]");
        public By AngularCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Angular')]");
        public By VueCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Vue')]");
        public By PublicCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Public')]");
        public By PrivateCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Private')]");
        public By ClassifiedCheckBox { get; set; } = By.XPath("//span[@class='rct-checkbox'][contains(text(),'Classified')]");
 
    }
}
