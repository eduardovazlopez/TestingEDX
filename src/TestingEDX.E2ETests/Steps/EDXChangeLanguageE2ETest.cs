using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingEDXDemo.Pages;
using Xunit;

namespace TestingEDXDemo.Steps
{
    public class EDXChangeLanguageE2ETest : TestBase
    {
        private EDXHomePage eDXHomePage;

        public EDXChangeLanguageE2ETest() => eDXHomePage = new EDXHomePage(driver);

        [Fact]
        public void ChangeLanguage_WhenApplyClicked_ChangeToEnglish()
        {
            eDXHomePage.GoToEDXHomePage();
            Assert.Contains("Iniciar Sesión", eDXHomePage.loginLink.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,2000)");
            eDXHomePage.languageSelector.Click();
            eDXHomePage.selectEnglish.Click();
            eDXHomePage.changeLangButtonEs.Click();

            Assert.Equal("https://www.edx.org/", driver.Url);
            Assert.Contains("Sign In", eDXHomePage.loginLink.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase);
        }
    }
}
