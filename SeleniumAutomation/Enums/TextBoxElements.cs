using OpenQA.Selenium;

namespace SeleniumAutomation.Enums
{
    public  class TextBoxPageElements
    {
        public By TextBoxButton { get; set; } = By.XPath("//span[@class='text'][contains(text(),'Text Box')]");
        public By TextBoxTitle { get; set; } = By.XPath("//div[@class='main-header'][contains(text(),'Text Box')]");
        public By FullNameTextBox { get; set; } = By.XPath("//input[@placeholder='Full Name']");
    }
}
