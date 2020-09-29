using NUnit.Framework;
using BookswagonAzureTest.BaseClass;
using BookswagonAzureTest.Pages;

namespace BookswagonAzureTest.TestCases
{
    public class BookswagonTest:Base
    {
        [Test,Order(0)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
        }

        [Test,Order(1)]
        public void SearchBookTest()
        {
            SearchBook book = new SearchBook(driver);
            book.SearchBookPage();
        }
    }
}
