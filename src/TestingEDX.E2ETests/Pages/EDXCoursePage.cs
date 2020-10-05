using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingEDXDemo.Pages
{
    public class EDXCoursePage
    {
        private IWebDriver _driver;
        public IWebElement enrollButton => _driver.FindElement(By.XPath("//a[contains(@class,'enroll-btn')]"));
        public EDXCoursePage(IWebDriver driver) => _driver = driver;
    }
}
