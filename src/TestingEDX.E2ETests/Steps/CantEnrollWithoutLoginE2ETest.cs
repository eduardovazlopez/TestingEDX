using System;
using System.Collections.Generic;
using System.Text;
using TestingEDXDemo.Pages;
using Xunit;

namespace TestingEDXDemo.Steps
{
    public class CantEnrollWithoutLoginE2ETest : TestBase
    {
        private EDXAllCoursesPage eDXAllCoursesPage;
        private EDXCoursePage eDXCoursePage;

        public CantEnrollWithoutLoginE2ETest()
        {
            eDXAllCoursesPage = new EDXAllCoursesPage(driver);
            eDXCoursePage = new EDXCoursePage(driver);
        }

        [Fact]
        public void CantEnrollWithoutLogin_TryToEnroll_RedirectToRegisterPage()
        {
            eDXAllCoursesPage.GoToEDXAllCoursesPage();
            eDXAllCoursesPage.course.Click();

            eDXCoursePage.enrollButton.Click();

            Assert.StartsWith("https://courses.edx.org/register", driver.Url);
        }

    }
}
