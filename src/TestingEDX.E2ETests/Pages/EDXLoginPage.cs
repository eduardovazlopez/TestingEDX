using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingEDXDemo.Pages
{
    public class EDXLoginPage
    {
        private IWebDriver _driver;

        public IWebElement emailInput => _driver.FindElement(By.Name("email"));
        public IWebElement passwordInput => _driver.FindElement(By.Name("password"));
        public IWebElement singInButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement cantLoginMessage => _driver.FindElement(By.XPath("//h4[@class='message-title']"));
        public EDXLoginPage(IWebDriver driver) => _driver = driver;

        public void GoToEDXLoginPage() => _driver.Url = "https://courses.edx.org/login";
    }
}
