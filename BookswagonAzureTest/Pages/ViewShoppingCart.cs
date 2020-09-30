using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace BookswagonAzureTest.Pages
{
    class ViewShoppingCart
    {
        readonly string GiftMessage = ConfigurationManager.AppSettings["giftMessage"];

        IWebDriver driver;
        public ViewShoppingCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_txtGiftMessage")]
        IWebElement giftMessage { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_savecontinue")]
        IWebElement saveAndContinueBtn1 { get; set; }

        public void ViewShoppingCartPage()
        {
            giftMessage.SendKeys("");
            saveAndContinueBtn1.Click();
            Thread.Sleep(1000);
        }
    }
}
