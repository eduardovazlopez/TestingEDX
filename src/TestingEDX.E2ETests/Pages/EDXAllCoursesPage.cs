using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingEDXDemo.Pages
{
    public class EDXAllCoursesPage
    {
        private IWebDriver _driver;

        public IWebElement course => _driver.FindElement(By.XPath("//a[@class='discovery-card-link']"));
        public EDXAllCoursesPage(IWebDriver driver) => _driver = driver;
        public void GoToEDXAllCoursesPage() => _driver.Url = "https://www.edx.org/search?tab=course";
    }
}
