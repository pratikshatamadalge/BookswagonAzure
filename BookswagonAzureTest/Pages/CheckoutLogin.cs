using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace BookswagonAzureTest.Pages
{
    class CheckoutLogin
    {
        public IWebDriver driver;

        public CheckoutLogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-red']")]
        IWebElement continueBtn { get; set; }

        public void CheckoutLoginPage()
        {
            Thread.Sleep(2000);
            continueBtn.Click();
        }
    }
}