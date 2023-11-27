using OpenQA.Selenium;

namespace SeleniumAutomation.Enums
{
    public  class TextBoxPageElements
    {
        public By TextBoxButton { get; set; } = By.XPath("//span[@class='text'][contains(text(),'Text Box')]");
        public By TextBoxTitle { get; set; } = By.XPath("//div[@class='main-header'][contains(text(),'Text Box')]");
        public By FullNameTextBox { get; set; } = By.XPath("//input[@placeholder='Full Name']");
        public By EmailTextBox { get; set; } = By.Id("userEmail");
        public By CurrentAddressTextBox { get; set; } = By.Id("currentAddress");
        public By PermanentAddressTextBox { get; set; } = By.Id("permanentAddress");
        public By SubmitButton { get; set; } = By.Id("submit");
        public By DisplayedNameText { get; set; } = By.XPath("//p[@id='name']");
        public By DisplayedEmailText { get; set; } = By.XPath("//p[@id='email']");
        public By DisplayedCurrentAddressText { get; set; } = By.XPath("//p[@id='currentAddress']");
        public By DisplayedPermanentAddressText { get; set; } = By.XPath("//p[@id='permanentAddress']");
    }
}
