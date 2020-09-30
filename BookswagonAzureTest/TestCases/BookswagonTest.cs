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

        [Test,Order(2)]
        public void ShoppingCartTest()
        {
            ShoppingCart cart = new ShoppingCart(driver);
            cart.CartPage();
        }

        [Test,Order(3)]
        public void CheckoutLoginTest()
        {
            CheckoutLogin checkout = new CheckoutLogin(driver);
            checkout.CheckoutLoginPage();
        }

        [Test,Order(4)]
        public void ShippingAddressTest()
        {
            ShippingAddress shippingAddress = new ShippingAddress(driver);
            shippingAddress.ShippingAddressPage();
        }

        [Test,Order(5)]
        public void ViewShoppingCartTest()
        {
            ViewShoppingCart view = new ViewShoppingCart(driver);
            view.ViewShoppingCartPage();
        }
    }
}
