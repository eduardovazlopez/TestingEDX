using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingEDXDemo.Pages
{
    public class EDXHomePage
    {
        private IWebDriver _driver;
        public IWebElement loginLink => _driver.FindElement(By.XPath("//a[@href='https://courses.edx.org/login']" + "//span"));
        public IWebElement languageSelector => _driver.FindElement(By.Name("site-footer-language-select"));
        public IWebElement selectEnglish => _driver.FindElement(By.XPath("//select/option[@value='en']"));
        public IWebElement changeLangButtonEs => _driver.FindElement(By.XPath("//button[contains(text(), 'Enviar solicitud')]"));

        public EDXHomePage(IWebDriver driver) => _driver = driver;
        public void GoToEDXHomePage() => _driver.Url = "https://www.edx.org/es";
    }
}
