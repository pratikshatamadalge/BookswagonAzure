using NUnit.Framework;
using BookswagonAzureTest.BaseClass;
using BookswagonAzureTest.Pages;

namespace BookswagonAzureTest.TestCases
{
    public class BookswagonTest:Base
    {
        [Test]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
        }
    }
}
