using System;
using System.Collections.Generic;
using System.Text;
using TestingEDXDemo.Pages;
using Xunit;

namespace TestingEDXDemo.Steps
{
    public class EDXIncorrectLoginE2ETest : TestBase
    {
        private EDXLoginPage eDXLoginPage;
        public EDXIncorrectLoginE2ETest() => eDXLoginPage = new EDXLoginPage(driver);

        [Fact]
        public void Login_WithWrongUserAndPass_CantLogin()
        {
            eDXLoginPage.GoToEDXLoginPage();

            eDXLoginPage.emailInput.SendKeys("fakeuser@fakeemail.com");
            eDXLoginPage.passwordInput.SendKeys("12345");
            eDXLoginPage.singInButton.Click();

            Assert.True(eDXLoginPage.cantLoginMessage.Displayed);
        }
    }
}
