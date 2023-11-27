using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Enums
{
    public class DemoQAPageElements
    {
        public By CategoryCards { get; set; } = By.XPath("//div[@class='category-cards']");
        public By ElementsCard { get; set; } = By.XPath("//div[@class='card-body']//h5[text()='Elements']");
    }
}
