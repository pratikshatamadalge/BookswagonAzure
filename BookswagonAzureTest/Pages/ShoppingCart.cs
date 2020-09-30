using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAzureTest.Pages
{
    public class ShoppingCart
    {
        public IWebDriver driver;

        public ShoppingCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/iframe[1]")]
        public IWebElement placeOrderFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='qtytext']")]
        public IWebElement quantity { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='btn-red']")]
        public IWebElement placeorder { get; set; }

        public void CartPage()
        {
            driver.SwitchTo().Frame(placeOrderFrame);
            quantity.Clear();
            quantity.SendKeys("2");
            placeorder.Click();
        }
    }
}
